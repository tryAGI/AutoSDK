using AutoSDK.Generation;
using AutoSDK.Naming.Methods;

namespace AutoSDK.UnitTests;

public partial class DataTests
{
    [DataTestMethod]
    [DataRow("ai21.yaml")]
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
    [DataRow("replicate.yaml")]
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
    public Task PrepareData(string resourceName)
    {
        return VerifyAsync(Data.Prepare((
            new H.Resource(resourceName).AsString(),
            DefaultSettings with
            {
                GenerateJsonSerializerContextTypes = true,
                MethodNamingConvention = resourceName switch
                {
                    "mystic.yaml" => MethodNamingConvention.Summary,
                    "replicate.yaml" => MethodNamingConvention.OperationIdWithDots,
                    _ => default,
                },
                IgnoreOpenApiErrors = resourceName switch
                {
                    "elevenlabs.json" => true,
                    _ => false,
                },
            })),
            resourceName: Path.GetFileNameWithoutExtension(resourceName));
    }
}