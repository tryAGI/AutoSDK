using System.Collections.Immutable;
using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.OpenApi.Readers;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.OperationNameGenerators;
using OpenApiGenerator.Models;
using OpenApiSchema = Microsoft.OpenApi.Models.OpenApiSchema;
using NSwag;

namespace OpenApiGenerator.Sources;

internal static partial class Sources
{
    public static EquatableArray<FileWithName> GenerateUsingNSwag(
        AdditionalText text,
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        var yaml = text.GetText(cancellationToken)?.ToString() ?? string.Empty;
        var openApi = Task.Run(() =>
            OpenApiYamlDocument.FromYamlAsync(yaml, cancellationToken), cancellationToken).Result;
        var openApiDocument = new OpenApiStringReader().Read(yaml, out _);
        var schemas = openApiDocument.Components?.Schemas ?? new Dictionary<string, OpenApiSchema>();
        var prefix = Path.GetFileName(text.Path);
        var allAdditionalExcludedTypeNames = schemas.Keys
            .Select(schemaKey => GetAdditionalExcludedTypeNames(schemaKey, schemas))
            .SelectMany(x => x)
            .ToArray();
        
        var files = new List<FileWithName>();
        files.AddRange(schemas.Keys.Select(schemaKey =>
        {
            var excludedTypeNames = schemas.Keys
                .Where(x => x != schemaKey)
                .Concat(allAdditionalExcludedTypeNames.Except(GetAdditionalExcludedTypeNames(schemaKey, schemas)))
                .ToArray();
            
            return new FileWithName(
                Name: $"{prefix}.Models.{schemaKey}.cs",
                Text: Generate(openApi, excludedTypeNames));
        }));
        
        return files.ToImmutableArray();
    }
    
    
    private static string[] GetAdditionalExcludedTypeNames(
        string key,
        IDictionary<string, OpenApiSchema> schemas)
    {
        var schema = schemas[key];
        var existingNames = new HashSet<string>(
            schemas.Keys.Select(x => x.ToPropertyName()).ToArray());
        var enums = schema.Properties
            .Where(x => x.Value.Enum != null && x.Value.Enum.Any())
            .Select(x => $"{key}{x.Key.ToPropertyName()}")
            .ToArray();
        var objects = schema.Properties
            .Where(static x => x.Value.Type == "object" && x.Value.Reference == null)
            .SelectMany(x => existingNames.Contains(x.Key.ToPropertyName())
                ? new[]
                {
                    $"{x.Key.ToPropertyName()}1",
                } : Array.Empty<string>())
            .ToArray();
        
        return enums
            .Concat(objects)
            .ToArray();
    }
    
    private static string Generate(
        OpenApiDocument openApi,
        string[]? excludedTypeNames = null)
    {
        var generator = new CSharpClientGenerator(openApi, new CSharpClientGeneratorSettings
        {
            ClassName = "{controller}ApiClient",
            OperationNameGenerator = "MultipleClientsFromOperationId" switch
            {
                // should implement all options of NSwag.Commands.CodeGeneration.OperationGenerationMode 

                "MultipleClientsFromOperationId" => new MultipleClientsFromOperationIdOperationNameGenerator(),
                "MultipleClientsFromPathSegments" => new MultipleClientsFromPathSegmentsOperationNameGenerator(),
                // kept for backward compatibility
                "MultipleClientsFromFirstTagAndPathSegmentsOperation" => new MultipleClientsFromFirstTagAndPathSegmentsOperationNameGenerator(),
                "MultipleClientsFromFirstTagAndPathSegments" => new MultipleClientsFromFirstTagAndPathSegmentsOperationNameGenerator(),

                "MultipleClientsFromFirstTagAndOperationId" => new MultipleClientsFromFirstTagAndOperationIdGenerator(),
                "SingleClientFromOperationId" => new SingleClientFromOperationIdOperationNameGenerator(),
                "SingleClientFromPathSegments" => new SingleClientFromPathSegmentsOperationNameGenerator(),
                "MultipleClientsFromFirstTagAndOperationName" => new MultipleClientsFromFirstTagAndOperationNameGenerator(),
                _ => throw new NotImplementedException($"OperationGenerationMode is not implemented."),
            },
            AdditionalContractNamespaceUsages = Array.Empty<string>(),
            AdditionalNamespaceUsages = Array.Empty<string>(),
            ClientBaseClass = string.Empty,
            ClientBaseInterface = string.Empty,
            ClientClassAccessModifier = "public",
            ConfigurationClass = string.Empty,
            DisposeHttpClient = true,
            ExceptionClass = "ApiException",
            ProtectedMethods = Array.Empty<string>(),
            CSharpGeneratorSettings =
            {
                Namespace = "MyClients365",
                GenerateNullableReferenceTypes = true,
                GenerateNativeRecords = false,
                GenerateOptionalPropertiesAsNullable = true,
                GenerateDataAnnotations = true,
                GenerateDefaultValues = true,
                GenerateImmutableArrayProperties = false,
                GenerateImmutableDictionaryProperties = false,
                GenerateJsonMethods = false,
                EnforceFlagEnums = false,
                ExcludedTypeNames = Array.Empty<string>(),
                DictionaryInstanceType = "System.Collections.Generic.Dictionary",
                DictionaryType = "System.Collections.Generic.IDictionary",
                HandleReferences = false,
                InlineNamedAny = false,
                InlineNamedArrays = false,
                InlineNamedDictionaries = false,
                InlineNamedTuples = true,
                RequiredPropertiesMustBeDefined = true,
                TypeAccessModifier = "public",
                PropertySetterAccessModifier = "private",
                TimeType = "System.TimeSpan",
                TemplateDirectory = string.Empty,
                TimeSpanType = "System.TimeSpan",
                JsonConverters = Array.Empty<string>(),
                AnyType = "object",
                ArrayBaseType = "System.Collections.ObjectModel.Collection",
                ArrayInstanceType = "System.Collections.ObjectModel.Collection",
                ArrayType = "System.Collections.Generic.ICollection",
                ClassStyle = CSharpClassStyle.Poco,
                DateTimeType = "System.DateTimeOffset",
                DateType = "System.DateTimeOffset",
                DictionaryBaseType = "System.Collections.Generic.Dictionary",
                JsonLibrary = CSharpJsonLibrary.SystemTextJson,
            },
            CodeGeneratorSettings =
            {
                ExcludedTypeNames = excludedTypeNames ?? Array.Empty<string>(),
                InlineNamedAny = false,
                GenerateDefaultValues = true,
                TemplateDirectory = string.Empty,
                PropertyNameGenerator = new CSharpPropertyNameGenerator(),
            },
            UseBaseUrl = true,
            UseHttpClientCreationMethod = false,
            UseHttpRequestMessageCreationMethod = false,
            UseRequestAndResponseSerializationSettings = false,
            WrapDtoExceptions = true,
            WrapResponseMethods = Array.Empty<string>(),
            WrapResponses = false,
            ParameterArrayType = "System.Collections.Generic.IEnumerable",
            ParameterDateFormat = "yyyy-MM-dd",
            ParameterDateTimeFormat = "s",
            ParameterDictionaryType = "System.Collections.Generic.IDictionary",
            InjectHttpClient = true,
            QueryNullValue = string.Empty,
            HttpClientType = "System.Net.Http.HttpClient",
            ResponseArrayType = "System.Collections.Generic.ICollection",
            ResponseClass = "SwaggerResponse",
            ResponseDictionaryType = "System.Collections.Generic.IDictionary",
            SerializeTypeInformation = false,
            ExposeJsonSerializerSettings = false,
            ExcludedParameterNames = Array.Empty<string>(),
            GenerateOptionalParameters = false,
            GenerateBaseUrlProperty = true,
            GenerateClientClasses = false,
            GenerateClientInterfaces = false,
            GenerateDtoTypes = true,
            GenerateExceptionClasses = false,
            GeneratePrepareRequestAndProcessResponseAsAsyncMethods = false,
            GenerateResponseClasses = false,
            GenerateSyncMethods = false,
            GenerateUpdateJsonSerializerSettingsMethod = true,
        });

        return generator.GenerateFile();
    }
}