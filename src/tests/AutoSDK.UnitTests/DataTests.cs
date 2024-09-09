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
    [DataRow("langsmith.yaml")]
    [DataRow("leonardo.yaml")]
    [DataRow("ollama.yaml")]
    [DataRow("openai.yaml")]
    [DataRow("petstore.yaml")]
    [DataRow("replicate.yaml")]
    [DataRow("special-cases.yaml")]
    [DataRow("together.yaml")]
    [DataRow("twitch.json")]
    public Task PrepareData(string resourceName)
    {
        return VerifyAsync(Data.Prepare((
            new H.Resource(resourceName).AsString(),
            DefaultSettings with
            {
                GenerateJsonSerializerContextTypes = true,
                MethodNamingConvention = resourceName switch
                {
                    "replicate.yaml" => MethodNamingConvention.OperationIdWithDots,
                    _ => default,
                }
            })),
            resourceName: Path.GetFileNameWithoutExtension(resourceName));
    }
}