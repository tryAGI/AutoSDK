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
    public void XSpeakeasyUnknownValues_Allow_MarksEnumAsOpen()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                Status:
                                  type: string
                                  x-speakeasy-unknown-values: allow
                                  enum:
                                    - active
                                    - inactive
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        var enumType = data.Enums.FirstOrDefault(e => e.ClassName == "Status");
        enumType.Should().NotBe(default);
        enumType.IsOpenEnum.Should().BeTrue();
    }

    [TestMethod]
    public void XSpeakeasyUnknownValues_Disallow_LeavesEnumClosed()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                Status:
                                  type: string
                                  x-speakeasy-unknown-values: disallow
                                  enum:
                                    - active
                                    - inactive
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        var enumType = data.Enums.FirstOrDefault(e => e.ClassName == "Status");
        enumType.Should().NotBe(default);
        enumType.IsOpenEnum.Should().BeFalse();
    }

    [TestMethod]
    public void XFernEnum_ForwardCompatible_MarksEnumAsOpen()
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
                                      "forwardCompatible": true,
                                      "active": {
                                        "description": "Currently active",
                                        "casing": {
                                          "pascal": "Active"
                                        }
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
        enumType.IsOpenEnum.Should().BeTrue();
    }

    [TestMethod]
    public void SymbolicEnumValues_UseReadableEnumMemberNames()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                TraceFilterOperator:
                                  type: string
                                  enum:
                                    - "="
                                    - "!="
                                    - "&&"
                                    - "||"
                                    - ">"
                                    - ">="
                                    - "<"
                                    - "<="
                                    - "+"
                                    - "-"
                                    - "*"
                                    - "/"
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        var enumType = data.Enums.FirstOrDefault(e => e.ClassName == "TraceFilterOperator");
        enumType.Should().NotBe(default);
        (string Id, string Name)[] expected =
        [
            ("=", "Eq"),
            ("!=", "Neq"),
            ("&&", "And"),
            ("||", "Or"),
            (">", "Gt"),
            (">=", "Gte"),
            ("<", "Lt"),
            ("<=", "Lte"),
            ("+", "Plus"),
            ("-", "Minus"),
            ("*", "Multiply"),
            ("/", "Divide"),
        ];

        enumType.EnumValues.Select(v => (v.Id, v.Name)).Should().BeEquivalentTo(expected);
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
    public void OpenApi32TagMetadata_IsPreservedAndUsedInDocumentationSummary()
    {
        const string yaml = """
                            openapi: 3.2.0
                            info:
                              title: Test
                              version: 1.0.0
                            tags:
                              - name: admin
                                summary: Administrative endpoints
                              - name: users
                                x-displayName: User Management
                                summary: Administrative user operations
                                kind: nav
                                parent: admin
                            paths:
                              /users:
                                get:
                                  operationId: listUsers
                                  tags:
                                    - users
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

        var usersTag = data.Tags.FirstOrDefault(t => t.SafeName == "Users");
        usersTag.DisplayName.Should().Be("User Management");
        usersTag.Summary.Should().Be("Administrative user operations");
        usersTag.ParentName.Should().Be("admin");
        usersTag.Kind.Should().Be("nav");
        usersTag.DocumentationSummary.Should().Contain("User Management");
        usersTag.DocumentationSummary.Should().Contain("Administrative user operations");
        usersTag.DocumentationSummary.Should().Contain("Parent tag: admin");
        usersTag.DocumentationSummary.Should().Contain("Kind: nav");
    }

    [TestMethod]
    public void OpenApi32ServerName_IsUsedForBaseUrlSummary()
    {
        const string yaml = """
                            openapi: 3.2.0
                            info:
                              title: Test
                              version: 1.0.0
                            servers:
                              - name: Primary API
                                url: https://api.example.com/v1
                                description: Production environment
                            paths:
                              /users:
                                get:
                                  operationId: listUsers
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

        data.Clients.Should().ContainSingle();
        data.Clients[0].BaseUrlSummary.Should().Be("Primary API. Production environment");
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

    [TestMethod]
    public void XFernRequestName_UsedForReferencedRequestBody_WhenExtensionNamingEnabled()
    {
        const string json = """
                            {
                              "openapi": "3.0.1",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "paths": {
                                "/finetuning/{id}": {
                                  "patch": {
                                    "operationId": "UpdateFinetunedModel",
                                    "x-fern-request-name": "FinetuningUpdateFinetunedModelRequest",
                                    "parameters": [
                                      {
                                        "name": "id",
                                        "in": "path",
                                        "required": true,
                                        "schema": { "type": "string" }
                                      }
                                    ],
                                    "requestBody": {
                                      "required": true,
                                      "content": {
                                        "application/json": {
                                          "schema": {
                                            "$ref": "#/components/schemas/UpdateFinetunedModelRequest"
                                          }
                                        }
                                      }
                                    },
                                    "responses": {
                                      "200": { "description": "OK" }
                                    }
                                  }
                                }
                              },
                              "components": {
                                "schemas": {
                                  "UpdateFinetunedModelRequest": {
                                    "type": "object",
                                    "properties": {
                                      "name": { "type": "string" }
                                    }
                                  }
                                }
                              }
                            }
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateMethods = true,
            GenerateSdk = true,
            UseExtensionNaming = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((json, settings), GlobalSettings: settings));

        data.Classes.Select(x => x.ClassName).Should().Contain("FinetuningUpdateFinetunedModelRequest");
        data.Classes.Select(x => x.ClassName).Should().NotContain("UpdateFinetunedModelRequest");
        data.Methods[0].RequestType.CSharpTypeRaw.Should().Contain("FinetuningUpdateFinetunedModelRequest");
    }

    [TestMethod]
    public void XFernRequestName_UsedForInlineRequestBody_WhenExtensionNamingEnabled()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /jobs:
                                post:
                                  operationId: createJob
                                  x-fern-request-name: CreateJobParams
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          type: object
                                          properties:
                                            name:
                                              type: string
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateMethods = true,
            GenerateSdk = true,
            UseExtensionNaming = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Classes.Select(x => x.ClassName).Should().Contain("CreateJobParams");
        data.Methods[0].RequestType.CSharpTypeRaw.Should().Contain("CreateJobParams");
    }

    [TestMethod]
    public void XFernType_NormalizesLiteralAndDateTimeShapes()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: FernType
                              version: 1.0.0
                            paths:
                              /oauth/token:
                                post:
                                  operationId: getToken
                                  requestBody:
                                    required: true
                                    content:
                                      application/json:
                                        schema:
                                          type: object
                                          properties:
                                            client_id:
                                              type: string
                                            client_secret:
                                              type: string
                                            grant_type:
                                              x-fern-type: literal<"client_credentials">
                                          required:
                                            - client_id
                                            - client_secret
                                            - grant_type
                                  responses:
                                    '200':
                                      description: OK
                              /transcript:
                                get:
                                  operationId: getTranscript
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            type: object
                                            properties:
                                              created:
                                                type: string
                                                x-fern-type: datetime
                                              completed:
                                                x-fern-type: optional<datetime>
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateMethods = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Classes.Select(x => x.ClassName).Should().Contain("GetTokenRequest");
        data.Classes.Select(x => x.ClassName).Should().NotContain("GetTokenRequestGrantType");

        var requestModel = data.Classes.First(x => x.ClassName == "GetTokenRequest");
        var grantType = requestModel.Properties.First(x => x.Id == "grant_type");
        grantType.Type.CSharpTypeWithoutNullability.Should().Be("string");
        grantType.IsRequired.Should().BeFalse();
        grantType.DefaultValue.Should().Be("\"client_credentials\"");

        var transcriptModel = data.Classes.First(x => x.ClassName == "GetTranscriptResponse");
        var created = transcriptModel.Properties.First(x => x.Id == "created");
        created.Type.CSharpTypeWithoutNullability.Should().Be("global::System.DateTime");
        created.Type.CSharpTypeNullability.Should().BeTrue();

        var completed = transcriptModel.Properties.First(x => x.Id == "completed");
        completed.Type.CSharpTypeWithoutNullability.Should().Be("global::System.DateTime");
        completed.Type.CSharpTypeNullability.Should().BeTrue();
    }

    [TestMethod]
    public void XFernSdkGroupName_EmptyTagsFilteredFromResolvedTags()
    {
        // When x-fern-sdk-group-name reassigns ALL operations away from their original tag,
        // that original tag should be excluded from the resolved tags list.
        const string json = """
                            {
                              "openapi": "3.0.1",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "tags": [
                                { "name": "OriginalTag" },
                                { "name": "OtherTag" }
                              ],
                              "paths": {
                                "/files/upload": {
                                  "post": {
                                    "operationId": "uploadFile",
                                    "x-fern-sdk-group-name": "files",
                                    "tags": ["OriginalTag"],
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

        // OriginalTag lost its only method to x-fern-sdk-group-name: "files",
        // so it should be excluded from Tags (no empty sub-client generated).
        data.Tags.Select(t => t.SafeName).Should().NotContain("OriginalTag");
        // The ad-hoc "files" tag and "OtherTag" should remain (they have methods).
        data.Tags.Select(t => t.SafeName).Should().Contain("Files");
        data.Tags.Select(t => t.SafeName).Should().Contain("OtherTag");
    }

    [TestMethod]
    public void CliCommandClassName_IncludesTagPrefix_WhenGrouped()
    {
        // When multiple groups have methods with the same name (e.g. "create"),
        // CliCommandClassName includes the tag prefix to avoid collisions.
        const string json = """
                            {
                              "openapi": "3.0.1",
                              "info": { "title": "Test", "version": "1.0.0" },
                              "paths": {
                                "/datasets": {
                                  "post": {
                                    "operationId": "createDataset",
                                    "x-fern-sdk-group-name": "datasets",
                                    "x-fern-sdk-method-name": "create",
                                    "tags": ["Data"],
                                    "responses": {
                                      "200": { "description": "OK" }
                                    }
                                  }
                                },
                                "/connectors": {
                                  "post": {
                                    "operationId": "createConnector",
                                    "x-fern-sdk-group-name": "connectors",
                                    "x-fern-sdk-method-name": "create",
                                    "tags": ["Data"],
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
        var cliNames = data.Methods.Select(m => m.CliCommandClassName).ToArray();
        // Both methods are named "Create" but in different groups,
        // so CliCommandClassName should include the tag prefix.
        cliNames.Should().OnlyHaveUniqueItems();
        cliNames.Should().Contain("DatasetsCreateCommand");
        // Second "create" method gets a "2" suffix from collision resolution,
        // then tag prefix makes it unique across groups.
        cliNames.Should().Contain("ConnectorsCreate2Command");
    }

    [TestMethod]
    public void XSpeakeasyIgnore_SkipsOperations_WhenUseExtensionNamingEnabled()
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
                                  x-speakeasy-ignore: true
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
    public void XSpeakeasyNameOverride_UsedForMethodNames_WhenExtensionNamingEnabled()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /messages:
                                post:
                                  operationId: createMessage
                                  x-speakeasy-name-override: send_message
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
        data.Methods[0].Id.Should().Be("SendMessage");
    }

    [TestMethod]
    public void XSpeakeasyGroup_OverridesTag_WhenExtensionNamingEnabled()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /messages:
                                post:
                                  operationId: createMessage
                                  tags:
                                    - DefaultTag
                                  x-speakeasy-group: messages
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var settings = DefaultSettings with
        {
            GenerateMethods = true,
            GenerateSdk = true,
            GroupByTags = true,
            UseExtensionNaming = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(1);
        data.Methods[0].ClassName.Should().Contain("Messages");
        data.Tags.Select(x => x.SafeName).Should().Contain("Messages");
    }

    [TestMethod]
    public void XSpeakeasyNameOverride_UsedForPropertyAndInlineTypeNames_WhenExtensionNamingEnabled()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                JsonSchema:
                                  type: object
                                  properties:
                                    schema:
                                      type: object
                                      x-speakeasy-name-override: schema_definition
                                      properties:
                                        type:
                                          type: string
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
            UseExtensionNaming = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        var jsonSchema = data.Classes.First(x => x.ClassName == "JsonSchema");
        jsonSchema.Properties.First(x => x.Id == "schema").Name.Should().Be("SchemaDefinition");
        data.Classes.Select(x => x.ClassName).Should().Contain("SchemaDefinition");
    }

    [TestMethod]
    public void XSpeakeasyEnumsAndDescriptions_OverrideEnumMetadata_MapFormat()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                Status:
                                  type: string
                                  enum:
                                    - active
                                    - inactive
                                  x-speakeasy-enums:
                                    active: Enabled
                                    inactive: Disabled
                                  x-speakeasy-enum-descriptions:
                                    active: Currently enabled
                                    inactive: Currently disabled
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        var enumType = data.Enums.First(x => x.ClassName == "Status");
        enumType.EnumValues.First(x => x.Id == "active").Name.Should().Be("Enabled");
        enumType.EnumValues.First(x => x.Id == "active").Summary.Should().Contain("Currently enabled");
        enumType.EnumValues.First(x => x.Id == "inactive").Name.Should().Be("Disabled");
        enumType.EnumValues.First(x => x.Id == "inactive").Summary.Should().Contain("Currently disabled");
    }

    [TestMethod]
    public void XSpeakeasyDeprecationMessage_UsedForSchemas()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                OldModel:
                                  type: object
                                  deprecated: true
                                  x-speakeasy-deprecation-message: Use NewModel instead.
                                  properties:
                                    value:
                                      type: string
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Classes.Should().ContainSingle(x => x.ClassName == "OldModel");
        data.Classes[0].DeprecationMessage.Should().Be("Use NewModel instead.");
    }

    [TestMethod]
    public void XStainlessNaming_CSharpPropertyName_OverridesPropertyName_WhenExtensionNamingEnabled()
    {
        const string yaml = """
                            openapi: 3.1.0
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                FineTune:
                                  type: object
                                  properties:
                                    model_id:
                                      type: string
                                      x-stainless-naming:
                                        csharp:
                                          property_name: llm_model_id
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
            UseExtensionNaming = true,
            TargetFramework = "net8.0",
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        var fineTune = data.Classes.First(x => x.ClassName == "FineTune");
        fineTune.Properties.First(x => x.Id == "model_id").Name.Should().Be("LlmModelId");
    }

    [TestMethod]
    public void XStainlessNaming_DotNetTypeName_OverridesModelName_WhenExtensionNamingEnabled()
    {
        const string yaml = """
                            openapi: 3.1.0
                            info:
                              title: Test
                              version: 1.0.0
                            paths: {}
                            components:
                              schemas:
                                LegacyPayload:
                                  type: object
                                  x-stainless-naming:
                                    dotnet:
                                      model_name: response_payload
                                  properties:
                                    value:
                                      type: string
                            """;

        var settings = DefaultSettings with
        {
            GenerateModels = true,
            GenerateSdk = true,
            UseExtensionNaming = true,
            TargetFramework = "net8.0",
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Classes.Select(x => x.ClassName).Should().Contain("ResponsePayload");
    }

    [TestMethod]
    public void XStainlessSkip_SkipsOperations_WhenLanguageIncludesDotNet()
    {
        const string yaml = """
                            openapi: 3.1.0
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /hidden:
                                get:
                                  operationId: getHidden
                                  x-stainless-skip:
                                    - dotnet
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
            TargetFramework = "net8.0",
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Should().HaveCount(1);
        data.Methods[0].Id.Should().Be("GetVisible");
    }
}
