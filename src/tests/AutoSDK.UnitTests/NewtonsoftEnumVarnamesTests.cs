using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.UnitTests;

[TestClass]
public class NewtonsoftEnumVarnamesTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "net6.0",
        Namespace = "G",
        ClassName = "Api",
        JsonSerializerType = JsonSerializerType.NewtonsoftJson,
        GenerateSdk = true,
        GenerateModels = true,
        GenerateMethods = true,
        ClsCompliantEnumPrefix = "x",
    };

    [TestMethod]
    public void IndirectEnumReference_UsesXEnumVarnamesInNewtonsoftMethodSwitches()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: enum-varnames-ref
                              version: 1.0.0
                            paths:
                              /logs:
                                get:
                                  operationId: getLogs
                                  parameters:
                                    - in: query
                                      name: direction
                                      schema:
                                        $ref: '#/components/schemas/LogsDirectionAlias'
                                  responses:
                                    '200':
                                      description: ok
                            components:
                              schemas:
                                LogsDirection:
                                  type: string
                                  enum:
                                    - forward
                                    - backward
                                  x-enum-varnames:
                                    - LogsDirectionForward
                                    - LogsDirectionBackward
                                LogsDirectionAlias:
                                  $ref: '#/components/schemas/LogsDirection'
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var enumModel = data.Enums.Single(x => x.ClassName == "LogsDirection");
        var method = data.Methods.Single(x => x.MethodName == "GetLogsAsync");
        var parameter = method.QueryParameters.Single(x => x.ParameterName == "direction");
        var generatedMethod = Sources.GenerateEndPoint(method);

        parameter.Type.Properties.Should().BeEquivalentTo(enumModel.EnumValues.Select(x => x.Name));
        parameter.Type.EnumValues.Should().BeEquivalentTo(enumModel.EnumValues.Select(x => x.Id));
        generatedMethod.Should().Contain("global::G.LogsDirection.LogsDirectionForward => \"forward\"");
        generatedMethod.Should().Contain("global::G.LogsDirection.LogsDirectionBackward => \"backward\"");
        generatedMethod.Should().NotContain("global::G.LogsDirection.Forward =>");
        generatedMethod.Should().NotContain("global::G.LogsDirection.Backward =>");
    }

    [TestMethod]
    public void E2bNewtonsoftMethods_UseResolvedEnumMemberNamesFromXEnumVarnames()
    {
        var repositoryRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../../../.."));
        var specPath = Path.Combine(repositoryRoot, "specs", "e2b.yaml");
        var yaml = File.ReadAllText(specPath);

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));
        var logsDirectionEnum = data.Enums.Single(x => x.ClassName == "LogsDirection");
        var logsSourceEnum = data.Enums.Single(x => x.ClassName == "LogsSource");
        var sandboxesLogsMethod = Sources.GenerateEndPoint(
            data.Methods.Single(x => x.MethodName == "GetSandboxesBySandboxIDLogs2Async"));
        var templateLogsMethod = Sources.GenerateEndPoint(
            data.Methods.Single(x => x.MethodName == "GetTemplatesByTemplateIDBuildsByBuildIDLogsAsync"));

        logsDirectionEnum.EnumValues.Select(x => x.Name)
            .Should().Equal("LogsDirectionBackward", "LogsDirectionForward");
        logsSourceEnum.EnumValues.Select(x => x.Name)
            .Should().Equal("LogsSourcePersistent", "LogsSourceTemporary");

        sandboxesLogsMethod.Should().Contain("global::G.LogsDirection.LogsDirectionForward => \"forward\"");
        sandboxesLogsMethod.Should().Contain("global::G.LogsDirection.LogsDirectionBackward => \"backward\"");
        sandboxesLogsMethod.Should().NotContain("global::G.LogsDirection.Forward =>");
        sandboxesLogsMethod.Should().NotContain("global::G.LogsDirection.Backward =>");

        templateLogsMethod.Should().Contain("global::G.LogsDirection.LogsDirectionForward => \"forward\"");
        templateLogsMethod.Should().Contain("global::G.LogsDirection.LogsDirectionBackward => \"backward\"");
        templateLogsMethod.Should().Contain("global::G.LogsSource.LogsSourceTemporary => \"temporary\"");
        templateLogsMethod.Should().Contain("global::G.LogsSource.LogsSourcePersistent => \"persistent\"");
        templateLogsMethod.Should().NotContain("global::G.LogsSource.Temporary =>");
        templateLogsMethod.Should().NotContain("global::G.LogsSource.Persistent =>");
    }
}
