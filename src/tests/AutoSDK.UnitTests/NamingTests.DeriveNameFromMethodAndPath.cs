using AutoSDK.Naming.Methods;

namespace AutoSDK.UnitTests;

public partial class NamingTests
{
    [TestMethod]
    [DataRow("POST", "/models/{repo_id}/settings", "CreateModelsSettings")]
    [DataRow("GET", "/users/{user_id}/repos", "GetUsersRepos")]
    [DataRow("DELETE", "/projects/{project_id}", "DeleteProjects")]
    [DataRow("PUT", "/items/{id}/metadata", "PutItemsMetadata")]
    [DataRow("PATCH", "/orgs/{org_id}/teams/{team_id}", "PatchOrgsTeams")]
    public void DeriveNameFromMethodAndPath_BasicPaths(string method, string path, string expected)
    {
        MethodAndPathGenerator.DeriveNameFromMethodAndPath(method, path).Should().Be(expected);
    }

    [TestMethod]
    [DataRow("POST", "/api/models", "CreateModels")]
    [DataRow("GET", "/api/v1/users", "GetUsers")]
    [DataRow("POST", "/v1/chat/completions", "CreateChatCompletions")]
    [DataRow("GET", "/v2/models", "GetModels")]
    [DataRow("GET", "/v3/search/results", "GetSearchResults")]
    [DataRow("POST", "/v1beta/generate", "CreateGenerate")]
    [DataRow("POST", "/v2beta1/predict", "CreatePredict")]
    [DataRow("GET", "/api/v2/resources", "GetResources")]
    public void DeriveNameFromMethodAndPath_StripsVersionAndApiPrefixes(string method, string path, string expected)
    {
        MethodAndPathGenerator.DeriveNameFromMethodAndPath(method, path).Should().Be(expected);
    }

    [TestMethod]
    [DataRow("GET", "/a/b/c/d/e", "GetABCDE")]
    [DataRow("POST", "/organizations/{org_id}/projects/{project_id}/members/{member_id}/roles", "CreateOrganizationsProjectsMembersRoles")]
    public void DeriveNameFromMethodAndPath_DeeplyNestedPaths(string method, string path, string expected)
    {
        MethodAndPathGenerator.DeriveNameFromMethodAndPath(method, path).Should().Be(expected);
    }

    [TestMethod]
    [DataRow("GET", "/{id}", "Get")]
    [DataRow("POST", "/{org}/{repo}/{branch}", "Create")]
    public void DeriveNameFromMethodAndPath_AllParameterSegments(string method, string path, string expected)
    {
        MethodAndPathGenerator.DeriveNameFromMethodAndPath(method, path).Should().Be(expected);
    }

    [TestMethod]
    [DataRow("HEAD", "/health", "HeadHealth")]
    [DataRow("OPTIONS", "/cors", "OptionsCors")]
    [DataRow("TRACE", "/debug", "TraceDebug")]
    public void DeriveNameFromMethodAndPath_UncommonHttpMethods(string method, string path, string expected)
    {
        MethodAndPathGenerator.DeriveNameFromMethodAndPath(method, path).Should().Be(expected);
    }

    [TestMethod]
    [DataRow("POST", "/text-to-image", "CreateTextToImage")]
    [DataRow("GET", "/speech_to_text", "GetSpeechToText")]
    [DataRow("POST", "/image.generate", "CreateImageGenerate")]
    public void DeriveNameFromMethodAndPath_SpecialCharactersInPath(string method, string path, string expected)
    {
        MethodAndPathGenerator.DeriveNameFromMethodAndPath(method, path).Should().Be(expected);
    }
}
