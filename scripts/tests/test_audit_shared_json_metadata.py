import importlib.util
from pathlib import Path
import tempfile
import unittest
import zipfile

spec = importlib.util.spec_from_file_location("metadata_audit", Path(__file__).parents[1] / "audit-shared-json-metadata.py")
audit = importlib.util.module_from_spec(spec)
spec.loader.exec_module(audit)


class MetadataAuditTests(unittest.TestCase):
    def test_valid_version_binding_and_failure_modes(self):
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            generated = root / "Generated"
            generated.mkdir()
            (root / "generate.sh").write_text("autosdk generate spec.yaml --shared-json-metadata")
            (generated / "Fixture.autosdk-json-metadata").write_text(
                f"// AutoSDK.JsonMetadata manifest-format: {audit.PROTOCOL}\n")
            binding = generated / "AutoSDK.SharedJsonMetadata.props"
            binding.write_text(f"<Project><PropertyGroup><AutoSDKJsonMetadataVersion>1.2.3-preview.4</AutoSDKJsonMetadataVersion>"
                               f"<AutoSDKJsonMetadataManifestVersion>{audit.PROTOCOL}</AutoSDKJsonMetadataManifestVersion></PropertyGroup></Project>")
            project = root / "Fixture.csproj"
            valid = ('<Project><PropertyGroup><TargetFramework>net10.0</TargetFramework></PropertyGroup><Import Project="Generated/AutoSDK.SharedJsonMetadata.props" />'
                     '<ItemGroup><PackageReference Include="AutoSDK.JsonMetadata" Version="$(AutoSDKJsonMetadataVersion)" '
                     'PrivateAssets="all" /></ItemGroup></Project>')
            project.write_text(valid)
            self.assertEqual([], audit.audit_project(project, "1.2.3-preview.4")["errors"])
            self.assertTrue(audit.audit_project(project, "1.2.3-preview.5")["errors"])
            for old, new in [('PrivateAssets="all"', ''), ('$(AutoSDKJsonMetadataVersion)', '1.2.3'),
                             ('<Import Project="Generated/AutoSDK.SharedJsonMetadata.props" />', '')]:
                with self.subTest(change=old):
                    project.write_text(valid.replace(old, new))
                    self.assertTrue(audit.audit_project(project)["errors"])
            project.write_text(valid)
            # Published protocol-2 SDKs remain valid; protocol-3 analyzers also accept
            # older subtrees while an SDK migrates them. An older binding cannot emit 3.
            manifest = generated / "Fixture.autosdk-json-metadata"
            for binding_version, manifest_version, accepted in [(2, 2, True), (3, 2, True),
                                                                (3, 3, True), (2, 3, False),
                                                                (3, 4, False), (3, 1, False)]:
                with self.subTest(binding=binding_version, manifest=manifest_version):
                    binding.write_text(f"<Project><PropertyGroup><AutoSDKJsonMetadataVersion>1.2.3-preview.4</AutoSDKJsonMetadataVersion>"
                                       f"<AutoSDKJsonMetadataManifestVersion>{binding_version}</AutoSDKJsonMetadataManifestVersion></PropertyGroup></Project>")
                    manifest.write_text(f"// AutoSDK.JsonMetadata manifest-format: {manifest_version}\n")
                    self.assertEqual(accepted, not audit.audit_project(project)["errors"])
            binding.unlink()
            self.assertTrue(audit.audit_project(project)["errors"])

    def test_legacy_manifests_are_visible_migration_failures(self):
        with tempfile.TemporaryDirectory() as directory:
            root = Path(directory)
            (root / "Generated").mkdir()
            (root / "Generated/Fixture.autosdk-json-metadata").write_text("#nullable enable\n")
            project = root / "Fixture.csproj"
            project.write_text("<Project />")
            self.assertTrue(audit.audit_project(project)["errors"])

    def test_packaged_build_dependency_is_rejected(self):
        with tempfile.TemporaryDirectory() as directory:
            package = Path(directory) / "Fixture.nupkg"
            for dependency, expected in [("Microsoft.Extensions.AI.Abstractions", False), ("AutoSDK.JsonMetadata", True),
                                         ("Microsoft.CodeAnalysis.CSharp", True)]:
                with self.subTest(dependency=dependency):
                    with zipfile.ZipFile(package, "w") as archive:
                        archive.writestr("Fixture.nuspec", f'<package><metadata><dependencies><dependency id="{dependency}" /></dependencies></metadata></package>')
                    self.assertEqual(expected, bool(audit.audit_package(package)["errors"]))

    def test_build_assemblies_cannot_hide_in_runtime_assets(self):
        with tempfile.TemporaryDirectory() as directory:
            package = Path(directory) / "Fixture.nupkg"
            for path, rejected in [("lib/net10.0/Microsoft.CodeAnalysis.CSharp.dll", True),
                                   ("runtimes/linux-x64/lib/net10.0/AutoSDK.JsonMetadata.dll", True),
                                   ("analyzers/dotnet/cs/AutoSDK.JsonMetadata.dll", False),
                                   ("lib/net10.0/Fixture.dll", False)]:
                with self.subTest(path=path):
                    with zipfile.ZipFile(package, "w") as archive:
                        archive.writestr("Fixture.nuspec", '<package><metadata /></package>')
                        archive.writestr(path, b'fixture')
                    self.assertEqual(rejected, bool(audit.audit_package(package)["errors"]))


if __name__ == "__main__":
    unittest.main()
