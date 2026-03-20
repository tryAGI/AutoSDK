using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Naming.Methods;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

[TestClass]
public class ExtensionParsingTests
{
    private Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "netstandard2.0",
        Namespace = "G",
        ClassName = "Api",
        ClsCompliantEnumPrefix = "x",
    };

    [TestMethod]
    public void XLabel_UsedAsSummaryFallback_WhenDescriptionIsEmpty()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                Item:
                                  type: object
                                  properties:
                                    name:
                                      type: string
                                      x-label: "Display Name"
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        var nameProperty = data.Classes
            .SelectMany(c => c.Properties)
            .FirstOrDefault(p => p.Id == "name");
        nameProperty.Summary.Should().Contain("Display Name");
    }

    [TestMethod]
    public void XLabel_NotUsed_WhenDescriptionExists()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                Item:
                                  type: object
                                  properties:
                                    name:
                                      type: string
                                      description: Real description
                                      x-label: "Display Name"
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        var nameProperty = data.Classes
            .SelectMany(c => c.Properties)
            .FirstOrDefault(p => p.Id == "name");
        nameProperty.Summary.Should().Contain("Real description");
        nameProperty.Summary.Should().NotContain("Display Name");
    }

    [TestMethod]
    public void XEnumDescriptions_SetsEnumMemberSummaries_JsonFormat()
    {
        const string json = """
                            {
                              "openapi": "3.0.1",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "paths": {},
                              "components": {
                                "schemas": {
                                  "Priority": {
                                    "type": "string",
                                    "enum": ["low", "high"],
                                    "x-enum-descriptions": ["Low priority item", "High priority item"]
                                  }
                                }
                              }
                            }
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((json, settings), GlobalSettings: settings));

        var enumType = data.Enums.FirstOrDefault(e => e.ClassName == "Priority");
        enumType.Should().NotBe(default);

        var lowValue = enumType.EnumValues.FirstOrDefault(v => v.Id == "low");
        lowValue.Summary.Should().Contain("Low priority item");

        var highValue = enumType.EnumValues.FirstOrDefault(v => v.Id == "high");
        highValue.Summary.Should().Contain("High priority item");
    }

    [TestMethod]
    public void XEnumVarnames_OverridesEnumMemberNames()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                VolumeType:
                                  type: string
                                  enum:
                                    - read-only
                                    - read-write
                                  x-enum-varnames:
                                    - ReadOnly
                                    - ReadWrite
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        var enumType = data.Enums.FirstOrDefault(e => e.ClassName == "VolumeType");
        enumType.Should().NotBe(default);
        var memberNames = enumType.EnumValues.Select(v => v.Name).ToArray();
        memberNames.Should().Contain("ReadOnly");
        memberNames.Should().Contain("ReadWrite");
    }

    [TestMethod]
    public void XFernEnum_OverridesEnumMemberNames()
    {
        const string json = """
                            {
                              "openapi": "3.0.1",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "paths": {},
                              "components": {
                                "schemas": {
                                  "Status": {
                                    "type": "string",
                                    "enum": ["active", "inactive"],
                                    "x-fern-enum": {
                                      "active": {
                                        "description": "Currently active",
                                        "casing": {
                                          "pascal": "Active"
                                        }
                                      },
                                      "inactive": {
                                        "description": "Currently inactive"
                                      }
                                    }
                                  }
                                }
                              }
                            }
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((json, settings), GlobalSettings: settings));

        var enumType = data.Enums.FirstOrDefault(e => e.ClassName == "Status");
        enumType.Should().NotBe(default);

        var activeValue = enumType.EnumValues.FirstOrDefault(v => v.Id == "active");
        activeValue.Name.Should().Be("Active");
        activeValue.Summary.Should().Contain("Currently active");

        var inactiveValue = enumType.EnumValues.FirstOrDefault(v => v.Id == "inactive");
        inactiveValue.Summary.Should().Contain("Currently inactive");
    }

    [TestMethod]
    public void XStainlessDeprecationMessage_UsedForOperations()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /old:
                                get:
                                  operationId: getOld
                                  deprecated: true
                                  x-stainless-deprecation-message: "Will be removed on July 21st, 2025"
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(1);
        data.Methods[0].DeprecationMessage.Should().Be("Will be removed on July 21st, 2025");
    }

    [TestMethod]
    public void XNullable_MakesSchemaNullable()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                Item:
                                  type: object
                                  required:
                                    - name
                                  properties:
                                    name:
                                      type: string
                                      x-nullable: true
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        var nameProperty = data.Classes
            .SelectMany(c => c.Properties)
            .FirstOrDefault(p => p.Id == "name");
        // x-nullable makes the property nullable, so it's no longer required in constructor
        nameProperty.Type.CSharpTypeNullability.Should().BeTrue();
    }

    [TestMethod]
    public void XFernIgnore_SkipsOperations_WhenUseExtensionNamingEnabled()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /internal:
                                get:
                                  operationId: getInternal
                                  x-fern-ignore: true
                                  responses:
                                    '200':
                                      description: OK
                              /public:
                                get:
                                  operationId: getPublic
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            UseExtensionNaming = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(1);
        data.Methods[0].Id.Should().Be("GetPublic");
    }

    [TestMethod]
    public void XFernIgnore_DoesNotSkipOperations_WhenUseExtensionNamingDisabled()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /internal:
                                get:
                                  operationId: getInternal
                                  x-fern-ignore: true
                                  responses:
                                    '200':
                                      description: OK
                              /public:
                                get:
                                  operationId: getPublic
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            UseExtensionNaming = false,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(2);
    }

    [TestMethod]
    public void XHidden_SkipsOperations_WhenUseExtensionNamingEnabled()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /hidden:
                                get:
                                  operationId: getHidden
                                  x-hidden: true
                                  responses:
                                    '200':
                                      description: OK
                              /visible:
                                get:
                                  operationId: getVisible
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            UseExtensionNaming = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(1);
        data.Methods[0].Id.Should().Be("GetVisible");
    }

    [TestMethod]
    public void XFernSdkMethodName_UsedWhenExtensionNamingEnabled()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /transcripts:
                                post:
                                  operationId: create_transcript_v2
                                  x-fern-sdk-method-name: submit
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            UseExtensionNaming = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(1);
        data.Methods[0].Id.Should().Be("Submit");
    }

    [TestMethod]
    public void XFernSdkMethodName_IgnoredWhenExtensionNamingDisabled()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /transcripts:
                                post:
                                  operationId: create_transcript_v2
                                  x-fern-sdk-method-name: submit
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            UseExtensionNaming = false,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(1);
        data.Methods[0].Id.Should().Be("CreateTranscriptV2");
    }

    [TestMethod]
    public void XFernSdkGroupName_OverridesTag_WhenExtensionNamingEnabled()
    {
        const string json = """
                            {
                              "openapi": "3.0.1",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "paths": {
                                "/files/upload": {
                                  "post": {
                                    "operationId": "uploadFile",
                                    "x-fern-sdk-group-name": "files",
                                    "tags": ["DefaultTag"],
                                    "responses": {
                                      "200": { "description": "OK" }
                                    }
                                  }
                                },
                                "/other": {
                                  "get": {
                                    "operationId": "getOther",
                                    "tags": ["OtherTag"],
                                    "responses": {
                                      "200": { "description": "OK" }
                                    }
                                  }
                                }
                              }
                            }
                            """;

        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            GroupByTags = true,
            UseExtensionNaming = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((json, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(2);
        // x-fern-sdk-group-name overrides the tag for uploadFile, so its client class should reference "files"
        var uploadMethod = data.Methods.First(m => m.Id == "UploadFile");
        uploadMethod.ClassName.Should().Contain("Files");
    }

    [TestMethod]
    public void XStainlessConst_TreatsPropertyAsNonRequired_WhenDefaultExists()
    {
        const string json = """
                            {
                              "openapi": "3.1.0",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "paths": {},
                              "components": {
                                "schemas": {
                                  "TextBlock": {
                                    "type": "object",
                                    "required": ["type", "text"],
                                    "properties": {
                                      "type": {
                                        "type": "string",
                                        "default": "text",
                                        "x-stainless-const": true
                                      },
                                      "text": {
                                        "type": "string"
                                      }
                                    }
                                  }
                                }
                              }
                            }
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
            TargetFramework = "net8.0",
        };
        var data = AutoSDK.Generation.Data.Prepare(((json, settings), GlobalSettings: settings));

        var typeProperty = data.Classes
            .SelectMany(c => c.Properties)
            .FirstOrDefault(p => p.Id == "type");
        // x-stainless-const with default makes the property non-required (has fixed value)
        typeProperty.IsRequired.Should().BeFalse();
    }

    [TestMethod]
    public void XStainlessConst_DoesNotAffectProperty_WhenNoDefault()
    {
        const string json = """
                            {
                              "openapi": "3.1.0",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "paths": {},
                              "components": {
                                "schemas": {
                                  "TextBlock": {
                                    "type": "object",
                                    "required": ["type", "text"],
                                    "properties": {
                                      "type": {
                                        "type": "string",
                                        "x-stainless-const": true
                                      },
                                      "text": {
                                        "type": "string"
                                      }
                                    }
                                  }
                                }
                              }
                            }
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
            TargetFramework = "net8.0",
        };
        var data = AutoSDK.Generation.Data.Prepare(((json, settings), GlobalSettings: settings));

        var typeProperty = data.Classes
            .SelectMany(c => c.Properties)
            .FirstOrDefault(p => p.Id == "type");
        // Without a default value, x-stainless-const alone doesn't change required status
        typeProperty.IsRequired.Should().BeTrue();
    }

    [TestMethod]
    public void XDisplayName_UsedForTagDescription()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            tags:
                              - name: chat
                                x-displayName: Chat Completions
                            paths:
                              /chat:
                                post:
                                  operationId: createChat
                                  tags:
                                    - chat
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            GroupByTags = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        // The DisplayName from x-displayName should be stored on the Tag
        var chatTag = data.Tags.FirstOrDefault(t => t.SafeName == "Chat");
        chatTag.DisplayName.Should().Be("Chat Completions");
    }

    [TestMethod]
    public void XCodeSamples_ExtractedAsRemarks()
    {
        const string json = """
                            {
                              "openapi": "3.0.1",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "paths": {
                                "/items": {
                                  "get": {
                                    "operationId": "getItems",
                                    "x-codeSamples": [
                                      {
                                        "lang": "curl",
                                        "source": "curl https://api.example.com/items"
                                      }
                                    ],
                                    "responses": {
                                      "200": {
                                        "description": "OK"
                                      }
                                    }
                                  }
                                }
                              }
                            }
                            """;

        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((json, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(1);
        data.Methods[0].Remarks.Should().Contain("curl");
    }

    [TestMethod]
    public void XCodeSamples_PrefersCSharpOverCurl()
    {
        const string json = """
                            {
                              "openapi": "3.0.1",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "paths": {
                                "/items": {
                                  "get": {
                                    "operationId": "getItems",
                                    "x-codeSamples": [
                                      {
                                        "lang": "curl",
                                        "source": "curl https://api.example.com/items"
                                      },
                                      {
                                        "lang": "csharp",
                                        "source": "var client = new Client();"
                                      }
                                    ],
                                    "responses": {
                                      "200": {
                                        "description": "OK"
                                      }
                                    }
                                  }
                                }
                              }
                            }
                            """;

        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((json, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(1);
        data.Methods[0].Remarks.Should().Contain("var client = new Client();");
        data.Methods[0].Remarks.Should().NotContain("curl");
    }

    [TestMethod]
    public void XFernTypeName_UsedForClassName_WhenExtensionNamingEnabled()
    {
        const string json = """
                            {
                              "openapi": "3.0.1",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "paths": {},
                              "components": {
                                "schemas": {
                                  "ChatV2Response": {
                                    "type": "object",
                                    "x-fern-type-name": "NonStreamedChatResponse",
                                    "properties": {
                                      "text": { "type": "string" }
                                    }
                                  }
                                }
                              }
                            }
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
            UseExtensionNaming = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((json, settings), GlobalSettings: settings));

        data.Classes.Should().HaveCount(1);
        data.Classes[0].ClassName.Should().Be("NonStreamedChatResponse");
    }

    [TestMethod]
    public void XFernTypeName_IgnoredWhenExtensionNamingDisabled()
    {
        const string json = """
                            {
                              "openapi": "3.0.1",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "paths": {},
                              "components": {
                                "schemas": {
                                  "ChatV2Response": {
                                    "type": "object",
                                    "x-fern-type-name": "NonStreamedChatResponse",
                                    "properties": {
                                      "text": { "type": "string" }
                                    }
                                  }
                                }
                              }
                            }
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
            UseExtensionNaming = false,
        };
        var data = AutoSDK.Generation.Data.Prepare(((json, settings), GlobalSettings: settings));

        data.Classes.Should().HaveCount(1);
        data.Classes[0].ClassName.Should().Be("ChatV2Response");
    }
}
