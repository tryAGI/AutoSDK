﻿using AutoSDK.Generation;
using AutoSDK.Naming.Methods;

namespace AutoSDK.UnitTests;

public partial class DataTests
{
    [DataTestMethod]
    [DataRow("ai21.json")]
    [DataRow("anthropic.yaml")]
    [DataRow("assemblyai.yaml")]
    [DataRow("cohere.yaml")]
    [DataRow("dedoose.json")]
    [DataRow("github.yaml")]
    [DataRow("huggingface.yaml")]
    [DataRow("ipinfo.yaml")]
    [DataRow("langsmith.json")]
    [DataRow("leonardo.yaml")]
    [DataRow("ollama.yaml")]
    [DataRow("openai.yaml")]
    [DataRow("petstore.yaml")]
    [DataRow("replicate.json")]
    [DataRow("special-cases.yaml")]
    [DataRow("together.yaml")]
    [DataRow("mystic.yaml")]
    [DataRow("twitch.json")]
    [DataRow("heygen.yaml")]
    [DataRow("instill.yaml")]
    [DataRow("ideogram.yaml")]
    [DataRow("google-gemini.yaml")]
    [DataRow("vectara.yaml")]
    [DataRow("mistral.yaml")]
    [DataRow("weaviate.yaml")]
    [DataRow("elevenlabs.json")]
    [DataRow("jina.json")]
    [DataRow("recraft.yaml")]
    [DataRow("luma.yaml")]
    [DataRow("ultravox.yaml")]
    [DataRow("deepinfra.json")]
    public Task PrepareData(string resourceName)
    {
        var settings = DefaultSettings with
        {
            GenerateJsonSerializerContextTypes = true,
            MethodNamingConvention = resourceName switch
            {
                "mystic.yaml" => MethodNamingConvention.Summary,
                "replicate.json" => MethodNamingConvention.OperationIdWithDots,
                _ => default,
            },
            IgnoreOpenApiErrors = resourceName switch
            {
                "langsmith.json" => true,
                "elevenlabs.json" => true,
                "ai21.json" => true,
                "replicate.json" => true,
                "luma.yaml" => true,
                "openai.yaml" => true,
                "deepinfra.json" => true,
                "cohere.yaml" => true,
                _ => false,
            },
        };
        return VerifyAsync(
            data: Data.Prepare(((new H.Resource(resourceName).AsString(), settings), GlobalSettings: settings)),
            resourceName: Path.GetFileNameWithoutExtension(resourceName));
    }
}