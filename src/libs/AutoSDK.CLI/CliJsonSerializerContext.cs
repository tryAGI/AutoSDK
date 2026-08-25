using System.Text.Json.Serialization;
using AutoSDK.Generation;

namespace AutoSDK.CLI;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(RepresentationAuditFinding[]))]
internal sealed partial class CliJsonSerializerContext : JsonSerializerContext;
