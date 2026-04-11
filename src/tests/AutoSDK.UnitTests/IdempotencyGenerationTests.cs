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
