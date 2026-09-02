using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

/// <summary>
/// The two code-shape changes split-by-tags makes, and the guarantee that neither leaks into the
/// default single-project mode.
/// </summary>
/// <remarks>
/// Whether the resulting assemblies actually compile against each other is proven by
/// <c>CliSplitByTagsTests</c>; these tests pin the specific decisions so a regression names itself
/// instead of surfacing as a build error in a generated tree.
/// </remarks>
[TestClass]
public class SplitByTagsGenerationTests
{
    private const string OAuth2Spec = """
openapi: 3.0.3
info:
  title: Catalogue
  version: 1.0.0
servers:
  - url: https://api.example.com
security:
  - oauth2:
      - read
paths:
  /albums:
    get:
      operationId: listAlbums
      tags:
        - albums
      responses:
        '200':
          description: OK
  /artists:
    get:
      operationId: listArtists
      tags:
        - artists
      responses:
        '200':
          description: OK
components:
  securitySchemes:
    oauth2:
      type: oauth2
      flows:
        authorizationCode:
          authorizationUrl: https://api.example.com/oauth/authorize
          tokenUrl: https://api.example.com/oauth/token
          scopes:
            read: Read access.
""";

    private static Settings DefaultSettings => Settings.Default with
    {
        Namespace = "Catalogue",
        ClassName = "CatalogueClient",
        GenerateModels = true,
        GenerateSdk = true,
    };

    private static Settings SplitSettings => DefaultSettings with
    {
        SplitByTags = true,
        BasePackageId = "tryAGI.Catalogue",
    };

    [TestMethod]
    public void SharedRuntimeMembers_InDefaultMode_StayInternal()
    {
        var security = Sources.SecuritySupport(DefaultSettings);
        var options = Sources.OptionsSupport(DefaultSettings, includePollingSupport: true);

        security.Text.Should().Contain("internal static class EndPointSecurityResolver");
        security.Text.Should().NotContain("EditorBrowsable");
        options.Text.Should().Contain("internal static class AutoSDKRequestOptionsSupport");
        options.Text.Should().Contain("internal static class AutoSDKPollingSupport");
    }

    [TestMethod]
    public void SharedRuntimeMembers_InSplitMode_ArePublicButHiddenFromIntelliSense()
    {
        var security = Sources.SecuritySupport(SplitSettings);
        var options = Sources.OptionsSupport(SplitSettings, includePollingSupport: true);

        // Tag assemblies call these across an assembly boundary, so `internal` would not compile.
        security.Text.Should().Contain("public sealed class EndPointAuthorizationRequirement");
        security.Text.Should().Contain("public static class EndPointSecurityResolver");
        security.Text.Should().Contain("EditorBrowsableState.Never");
        options.Text.Should().Contain("public static class AutoSDKRequestOptionsSupport");
        options.Text.Should().Contain("public static class AutoSDKPollingSupport");

        // Members of a widened type must be reachable too, or the type alone buys nothing.
        security.Text.Should().Contain("public static global::System.Collections.Generic.List<EndPointAuthorization> ResolveAuthorizations(");
        options.Text.Should().Contain("public static string AppendQueryParameters(");
    }

    [TestMethod]
    public void SharedRuntimeMembers_InSplitModeWithStrongNameKey_StayInternal()
    {
        // With a key AutoSDK can emit InternalsVisibleTo instead, which keeps the public surface
        // of the Core package unchanged.
        var settings = SplitSettings with { StrongNamePublicKey = "00240000048000009400000006020000" };

        var security = Sources.SecuritySupport(settings);

        security.Text.Should().Contain("internal static class EndPointSecurityResolver");
        security.Text.Should().NotContain("EditorBrowsable");
    }

    [TestMethod]
    public void OAuth2SupportTypes_InDefaultMode_StayNestedInTheRootClient()
    {
        var data = PrepareData(OAuth2Spec, DefaultSettings);

        Sources.OAuth2SupportTypes(data.Authorizations).Should().Be(FileWithName.Empty);

        var authorization = Sources.Authorization(data.Authorizations.Single());
        authorization.Text.Should().Contain("public sealed class AutoSDKOAuth2Coordinator");

        var tagClient = Sources.Client(data.Clients.Single(x => x.ClassName == "AlbumsClient"));
        tagClient.Text.Should().Contain("global::Catalogue.CatalogueClient.AutoSDKOAuth2Coordinator");
    }

    [TestMethod]
    public void OAuth2SupportTypes_InSplitMode_MoveToTheirOwnNamespaceLevelFile()
    {
        var data = PrepareData(OAuth2Spec, SplitSettings);

        // Nested in the root client they would live in the facade, which every tag assembly would
        // then have to reference — while the facade already references every tag assembly.
        var supportTypes = Sources.OAuth2SupportTypes(data.Authorizations);
        supportTypes.Name.Should().Be("Catalogue.AutoSDKOAuth2.g.cs");
        supportTypes.Text.Should().Contain("namespace Catalogue");
        supportTypes.Text.Should().Contain("public sealed class AutoSDKOAuth2Coordinator");
        supportTypes.Text.Should().Contain("public sealed class OAuth2Token");
        supportTypes.Text.Should().Contain("public interface IOAuth2TokenStore");

        var authorization = Sources.Authorization(data.Authorizations.Single());
        authorization.Text.Should().NotContain("public sealed class AutoSDKOAuth2Coordinator");

        var tagClient = Sources.Client(data.Clients.Single(x => x.ClassName == "AlbumsClient"));
        tagClient.Text.Should().Contain("global::Catalogue.AutoSDKOAuth2Coordinator");
        tagClient.Text.Should().NotContain("global::Catalogue.CatalogueClient.AutoSDKOAuth2Coordinator");
    }

    [TestMethod]
    public void OAuth2SupportTypes_InSplitMode_AreReferencedConsistentlyByTheRootInterface()
    {
        var data = PrepareData(OAuth2Spec, SplitSettings);

        // The interface and the implementation must agree on where the types live, or the root
        // client silently stops implementing its own interface.
        var authorizationInterface = Sources.AuthorizationInterface(data.Authorizations.Single());
        authorizationInterface.Text.Should().Contain("global::Catalogue.OAuth2Token");
        authorizationInterface.Text.Should().NotContain("global::Catalogue.CatalogueClient.OAuth2Token");
        authorizationInterface.Text.Should().NotContain("global::Catalogue.CatalogueClient.IOAuth2TokenStore");
    }

    [TestMethod]
    public void TagOperationBodies_InSplitMode_CallTheHoistedOAuth2Helper()
    {
        var data = PrepareData(OAuth2Spec, SplitSettings);

        var method = Sources.Method(data.Methods.Single(x => x.MethodName == "ListAlbumsAsync"));

        method.Text.Should().Contain("global::Catalogue.AutoSDKOAuth2Helpers.SendAsync");
        method.Text.Should().NotContain("global::Catalogue.CatalogueClient.AutoSDKOAuth2Helpers");
    }

    [TestMethod]
    public void SharedMemberAccessibility_TracksTheModeAndTheStrongNameKey()
    {
        Settings.Default.SharedMemberAccessibility.Should().Be("internal");
        SplitSettings.SharedMemberAccessibility.Should().Be("public");
        (SplitSettings with { StrongNamePublicKey = "0024" }).SharedMemberAccessibility.Should().Be("internal");

        Settings.Default.HidesSharedMembersFromIntelliSense.Should().BeFalse();
        SplitSettings.HidesSharedMembersFromIntelliSense.Should().BeTrue();
        (SplitSettings with { StrongNamePublicKey = "0024" }).HidesSharedMembersFromIntelliSense.Should().BeFalse();
    }

    private static AutoSDK.Models.Data PrepareData(string yaml, Settings settings)
    {
        return AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
    }
}
