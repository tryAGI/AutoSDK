using System.Text.Json.Serialization;
using AutoSDK.Models;

namespace AutoSDK.Generation;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(GeneratedSdkSnippetManifest))]
[JsonSerializable(typeof(string))]
internal sealed partial class CSharpJsonSerializerContext : JsonSerializerContext;
