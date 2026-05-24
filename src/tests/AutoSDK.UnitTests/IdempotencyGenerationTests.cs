using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class IdempotencyGenerationTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "netstandard2.0",
        Namespace = "G",
        ClassName = "Api",
        GenerateSdk = true,
        GenerateConstructors = true,
    };

    [TestMethod]
    public void Prepare_FernIdempotentOperation_AddsGeneratedIdempotencyHeader()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Idempotency
                              version: 1.0.0
                            x-fern-idempotency-headers:
                              - header: Idempotency-Key
                                name: idempotency_key
                            paths:
                              /charges:
                                post:
                                  operationId: createCharge
                                  x-fern-idempotent: true
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)DefaultSettings), (CSharpSettings)DefaultSettings));
        var method = data.Methods.Single();
        var idempotencyParameter = method.Parameters.Should().ContainSingle(x => x.IsIdempotencyHeader).Subject;
        var methodSource = Sources.Method(method).Text;

        idempotencyParameter.Id.Should().Be("Idempotency-Key");
        idempotencyParameter.ParameterName.Should().Be("idempotencyKey");
        idempotencyParameter.IsRequired.Should().BeFalse();
        methodSource.Should().Contain("string? idempotencyKey = default");
        methodSource.Should().Contain("var __idempotencyKey = global::System.String.IsNullOrWhiteSpace(idempotencyKey)");
        methodSource.Should().Contain("CreateIdempotencyKey()");
        methodSource.Should().Contain("__httpRequest.Headers.TryAddWithoutValidation(\"Idempotency-Key\", __idempotencyKey);");
    }

    [TestMethod]
    public void Prepare_DeclaredIdempotencyHeader_PromotesExistingParameterToFirstClassSupport()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Existing Header
                              version: 1.0.0
                            paths:
                              /charges:
                                post:
                                  operationId: createCharge
                                  parameters:
                                    - in: header
                                      name: Idempotency-Key
                                      required: true
                                      schema:
                                        type: string
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)DefaultSettings), (CSharpSettings)DefaultSettings));
        var method = data.Methods.Single();
        var idempotencyParameter = method.Parameters.Should().ContainSingle(x => x.IsIdempotencyHeader).Subject;
        var methodSource = Sources.Method(method).Text;

        idempotencyParameter.IsRequired.Should().BeFalse();
        idempotencyParameter.ParameterName.Should().Be("idempotencyKey");
        methodSource.Should().Contain("__httpRequest.Headers.TryAddWithoutValidation(\"Idempotency-Key\", __idempotencyKey);");
        methodSource.Should().NotContain("TryAddWithoutValidation(\"Idempotency-Key\", idempotencyKey.ToString())");
    }

    [TestMethod]
    public void Prepare_XIdempotencyExtension_TreatedAsIdempotent()
    {
        // x-idempotency is the Stripe-style alias for x-fern-idempotent.
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Stripe-style
                              version: 1.0.0
                            paths:
                              /charges:
                                post:
                                  operationId: createCharge
                                  x-idempotency: true
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)DefaultSettings), (CSharpSettings)DefaultSettings));
        var method = data.Methods.Single();

        method.Parameters.Should().ContainSingle(x => x.IsIdempotencyHeader);
        method.Parameters.Single(x => x.IsIdempotencyHeader).Id.Should().Be("Idempotency-Key");
    }

    [TestMethod]
    public void Prepare_GenerateIdempotencyHelpers_AppliesToAllPostsWithoutSpecAnnotation()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Global Idempotency
                              version: 1.0.0
                            paths:
                              /charges:
                                post:
                                  operationId: createCharge
                                  responses:
                                    '200':
                                      description: OK
                              /charges/{id}:
                                get:
                                  operationId: getCharge
                                  parameters:
                                    - name: id
                                      in: path
                                      required: true
                                      schema:
                                        type: string
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with { GenerateIdempotencyHelpers = true };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));

        var post = data.Methods.Single(m => m.MethodName == "CreateChargeAsync");
        var get = data.Methods.Single(m => m.MethodName == "GetChargeAsync");

        post.Parameters.Should().ContainSingle(x => x.IsIdempotencyHeader, "POST is eligible by HTTP method");
        get.Parameters.Should().NotContain(x => x.IsIdempotencyHeader, "GET is safe/idempotent and should not get the header");
    }

    [TestMethod]
    public void Prepare_GenerateIdempotencyHelpers_HonorsCustomHeaderName()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Custom Header
                              version: 1.0.0
                            paths:
                              /charges:
                                post:
                                  operationId: createCharge
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with
        {
            GenerateIdempotencyHelpers = true,
            IdempotencyHeaderName = "x-idempotency-key",
        };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var method = data.Methods.Single();
        var idempotencyParameter = method.Parameters.Single(x => x.IsIdempotencyHeader);

        idempotencyParameter.Id.Should().Be("x-idempotency-key");
        var methodSource = Sources.Method(method).Text;
        methodSource.Should().Contain("__httpRequest.Headers.TryAddWithoutValidation(\"x-idempotency-key\", __idempotencyKey);");
    }

    [TestMethod]
    public void GenerateClient_WithIdempotencySupport_EmitsConfigurableKeyFactory()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Tagged Idempotency
                              version: 1.0.0
                            x-fern-idempotency-headers:
                              - header: Idempotency-Key
                                name: idempotency_key
                            paths:
                              /charges:
                                post:
                                  operationId: createCharge
                                  tags: [payments]
                                  x-fern-idempotent: true
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with
        {
            GroupByTags = true,
        };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var mainClient = data.Clients.Single(x => x.Id == "MainConstructor");
        var clientSource = Sources.Client(mainClient).Text;

        mainClient.HasIdempotencySupport.Should().BeTrue();
        clientSource.Should().Contain("public global::System.Func<string> CreateIdempotencyKey { get; set; }");
        clientSource.Should().Contain("global::System.Guid.NewGuid().ToString(\"D\")");
    }
}
