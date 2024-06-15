using OpenApiGenerator.Core.Generation;
using OpenApiGenerator.Core.Naming.Methods;

namespace OpenApiGenerator.UnitTests;

public partial class DataTests
{
    [TestMethod]
    public Task OpenAi()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.openai_yaml.AsString(),
            DefaultSettings)));
    }

    [TestMethod]
    public Task Ollama()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.ollama_yaml.AsString(),
            DefaultSettings with
            {
                GenerateJsonSerializerContextTypes = true,
            })));
    }

    [TestMethod]
    public Task Replicate()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.replicate_json.AsString(),
            DefaultSettings with
            {
                MethodNamingConvention = MethodNamingConvention.OperationIdWithDots,
            })));
    }
    
    // [TestMethod]
    // public Task GitHub()
    // {
    //     return VerifyAsync(Data.Prepare((
    //         H.Resources.api_github_com_yaml.AsString(),
    //         DefaultSettings)));
    // }

    [TestMethod]
    public Task LangSmith()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.langsmith_yaml.AsString(),
            DefaultSettings)));
    }

    [TestMethod]
    public Task SpecialCases()
    {
        return VerifyAsync(Data.Prepare((
            H.Resources.specialcases_yaml.AsString(),
            DefaultSettings)));
    }
}