using System.Text.Json.Serialization;
using AutoSDK.CLI.Commands;
using AutoSDK.Generation;

namespace AutoSDK.CLI;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(RepresentationAuditFinding[]))]
[JsonSerializable(typeof(GenerationCacheManifest))]
internal sealed partial class CliJsonSerializerContext : JsonSerializerContext;
