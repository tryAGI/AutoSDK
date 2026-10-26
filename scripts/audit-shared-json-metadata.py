#!/usr/bin/env python3
"""Audit explicitly selected generated SDK projects before migrating the next fleet batch."""
import argparse
import json
import re
from pathlib import Path
import xml.etree.ElementTree as ET
import zipfile

PROTOCOL = 3
SUPPORTED_PROTOCOLS = {2, 3}
BINDING = "Generated/AutoSDK.SharedJsonMetadata.props"


def audit_project(project, expected_version=None):
    project = Path(project)
    errors = []
    tree = ET.parse(project)
    manifests = sorted((project.parent / "Generated").rglob("*.autosdk-json-metadata"))
    generation = project.parent / "generate.sh"
    enabled = generation.exists() and "--shared-json-metadata" in generation.read_text()
    refs = [node for node in tree.iter("PackageReference")
            if node.get("Include") == "AutoSDK.JsonMetadata"]
    if not (enabled or manifests or refs):
        return {"project": str(project), "enabled": False, "errors": []}
    frameworks = [node.text for node in tree.iter() if node.tag in {"TargetFramework", "TargetFrameworks"}]
    if frameworks != ["net10.0"]:
        errors.append("shared metadata requires a validated monolithic net10.0 project")
    if generation.exists() and "--split-by-tags" in generation.read_text():
        errors.append("shared metadata is unsupported for split-package generation")
    if not enabled:
        errors.append("generation script does not enable --shared-json-metadata")
    if not manifests:
        errors.append("shared metadata manifest is missing; regenerate the SDK")
    if len(refs) != 1:
        errors.append("exactly one AutoSDK.JsonMetadata PackageReference is required")
    else:
        if refs[0].get("PrivateAssets", "").lower() != "all":
            errors.append("AutoSDK.JsonMetadata must use PrivateAssets=all")
        if refs[0].get("Version") != "$(AutoSDKJsonMetadataVersion)":
            errors.append("analyzer version must bind to $(AutoSDKJsonMetadataVersion)")
    imports = [node for node in tree.iter("Import") if node.get("Project", "").replace("\\", "/") == BINDING]
    if len(imports) != 1:
        errors.append("generated metadata package binding must be imported exactly once")
    binding = project.parent / BINDING
    version = None
    binding_protocol = None
    if not binding.exists():
        errors.append("generated metadata package binding is missing")
    else:
        properties = ET.parse(binding).getroot()
        version = properties.findtext(".//AutoSDKJsonMetadataVersion")
        if not version or not re.fullmatch(r"\d+\.\d+\.\d+(?:-[0-9A-Za-z.-]+)?", version):
            errors.append("generated analyzer package version is invalid")
        binding_protocol = properties.findtext(".//AutoSDKJsonMetadataManifestVersion")
        if binding_protocol not in {str(value) for value in SUPPORTED_PROTOCOLS}:
            errors.append("generated binding has an incompatible manifest protocol")
        if expected_version is not None and version != expected_version:
            errors.append(f"generated analyzer version differs from expected CLI release {expected_version}")
    for manifest in manifests:
        with manifest.open(encoding="utf-8-sig") as stream:
            first = stream.readline().strip()
        match = re.fullmatch(r"// AutoSDK.JsonMetadata manifest-format: (\d+)", first)
        protocol = int(match[1]) if match else None
        if (protocol not in SUPPORTED_PROTOCOLS or binding_protocol is None or
                not binding_protocol.isdigit() or protocol > int(binding_protocol)):
            errors.append(f"{manifest.name}: unversioned or incompatible manifest; regenerate with the matching CLI")
    return {"project": str(project), "enabled": enabled, "manifests": len(manifests),
            "analyzerVersion": version, "errors": errors}


def audit_package(package):
    with zipfile.ZipFile(package) as archive:
        nuspec = next(name for name in archive.namelist() if name.endswith(".nuspec"))
        root = ET.fromstring(archive.read(nuspec))
        dependencies = [node.get("id", "") for node in root.iter()
                        if node.tag.split("}")[-1] == "dependency"]
        runtime_files = [name for name in archive.namelist()
                         if name.lower().startswith(("lib/", "runtimes/"))
                         and name.lower().endswith(".dll") and is_build_only(Path(name).stem)]
    banned = [name for name in dependencies if is_build_only(name)]
    return {"package": str(package), "errors": ["build-only dependency leaked: " + name for name in banned]
            + ["build-only assembly in runtime assets: " + name for name in runtime_files]}


def is_build_only(name):
    return name.lower().startswith("microsoft.codeanalysis") or name.lower() in {
        "autosdk", "autosdk.csharp", "autosdk.jsonmetadata", "autosdk.sourcegenerators",
        "system.text.json.sourcegeneration"}


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("projects", nargs="*", type=Path)
    parser.add_argument("--workspace", type=Path, help="Read-only inventory of SDK projects under each repository")
    parser.add_argument("--expected-cli-version")
    parser.add_argument("--package", action="append", default=[], type=Path)
    args = parser.parse_args()
    projects = list(args.projects)
    if args.workspace:
        projects.extend(sorted(args.workspace.glob("*/src/libs/*/*.csproj")))
    if not (projects or args.package):
        parser.error("select projects, --workspace, or --package")
    results = [audit_project(project, args.expected_cli_version) for project in dict.fromkeys(projects)]
    results.extend(audit_package(package) for package in args.package)
    print(json.dumps(results, indent=2))
    return 1 if any(result["errors"] for result in results) else 0


if __name__ == "__main__":
    raise SystemExit(main())
