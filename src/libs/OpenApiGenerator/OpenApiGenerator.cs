using H.Generators.Extensions;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using NJsonSchema.CodeGeneration.CSharp;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using NSwag.CodeGeneration.OperationNameGenerators;

namespace H.Generators;

[Generator]
public class NSwagGenerator : IIncrementalGenerator
{
    #region Constants

    public const string Name = nameof(NSwagGenerator);
    public const string Id = "NSG";

    #endregion

    #region Properties

    public static Dictionary<string, string> Cache { get; } = new();

    #endregion

    #region Methods

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.AdditionalTextsProvider
            .Where(static text => text.Path.EndsWith(".nswag", StringComparison.InvariantCultureIgnoreCase))
            .Combine(context.AnalyzerConfigOptionsProvider
                .Select(static (x, _) => bool.Parse(x.GetGlobalOption("UseCache", prefix: Name) ?? bool.FalseString)))
            .SelectAndReportExceptions(GetSourceCode, context, Id)
            .AddSource(context);
    }

    private static FileWithName GetSourceCode(
        (AdditionalText text, bool useCache) tuple,
        CancellationToken cancellationToken = default)
    {
        var (text, useCache) = tuple;

        string source;
        if (useCache &&
            Cache.TryGetValue(text.Path, out var value))
        {
            source = value;
        }
        else
        {
            source = Task.Run(() => GenerateAsync(
                text.Path,
                cancellationToken), cancellationToken).Result;
            Cache[text.Path] = source;
        }

        return new FileWithName(
            Name: $"{Path.GetFileName(text.Path)}.cs",
            Text: source);
    }

    private static async Task<OpenApiDocument> GetOpenApiDocumentAsync(
        FromDocument fromDocument,
        string path,
        CancellationToken cancellationToken = default)
    {
        var folder = Path.GetDirectoryName(path) ?? string.Empty;

        var fromUrl = !string.IsNullOrWhiteSpace(fromDocument.Url);
        var fromFile = fromUrl && !fromDocument.Url.StartsWith("http", StringComparison.OrdinalIgnoreCase);
        if (fromUrl && !fromFile)
        {
            return await OpenApiDocument.FromUrlAsync(
                fromDocument.Url,
                cancellationToken).ConfigureAwait(false);
        }

        var json = fromFile
            ? File.ReadAllText(Path.Combine(folder, fromDocument.Url))
            : fromDocument.Json;
        var isJson = json.StartsWith("{", StringComparison.OrdinalIgnoreCase);

        return isJson
            ? await OpenApiDocument.FromJsonAsync(json, cancellationToken).ConfigureAwait(false)
            : await OpenApiYamlDocument.FromYamlAsync(json, cancellationToken).ConfigureAwait(false);
    }

    private static string GetTemplateDirectoryPath(string path, string templateDirectory)
    {
        if (string.IsNullOrEmpty(templateDirectory))
        {
            return templateDirectory;
        }

        var folder = Path.GetDirectoryName(path) ?? string.Empty;

        return Path.Combine(folder, templateDirectory);
    }

    public static async Task<string> GenerateAsync(
        string path,
        CancellationToken cancellationToken = default)
    {
        path = path ?? throw new ArgumentNullException(nameof(path));

        var json = File.ReadAllText(path);
        var document =
            JsonConvert.DeserializeObject<NSwagDocument>(json) ??
            throw new InvalidOperationException("Document is null.");
        var settings = document.CodeGenerators.OpenApiToCSharpClient;
        var openApi = await GetOpenApiDocumentAsync(
            document.DocumentGenerator.FromDocument,
            path,
            cancellationToken).ConfigureAwait(false);

        var templateDirectoryPath = GetTemplateDirectoryPath(path, settings.TemplateDirectory);

        var generator = new CSharpClientGenerator(openApi, new CSharpClientGeneratorSettings
        {
            ClassName = settings.ClassName,
            OperationNameGenerator = settings.OperationGenerationMode switch
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
                _ => throw new NotImplementedException($"OperationGenerationMode: {settings.OperationGenerationMode} is not implemented."),
            },
            AdditionalContractNamespaceUsages = settings.AdditionalContractNamespaceUsages,
            AdditionalNamespaceUsages = settings.AdditionalNamespaceUsages,
            ClientBaseClass = settings.ClientBaseClass,
            ClientBaseInterface = settings.ClientBaseInterface,
            ClientClassAccessModifier = settings.ClientClassAccessModifier,
            ConfigurationClass = settings.ConfigurationClass,
            DisposeHttpClient = settings.DisposeHttpClient,
            ExceptionClass = settings.ExceptionClass,
            ProtectedMethods = settings.ProtectedMethods,
            CSharpGeneratorSettings =
            {
                Namespace = settings.Namespace,
                GenerateNullableReferenceTypes = settings.GenerateNullableReferenceTypes,
                GenerateNativeRecords = settings.GenerateNativeRecords,
                GenerateOptionalPropertiesAsNullable = settings.GenerateOptionalPropertiesAsNullable,
                GenerateDataAnnotations = settings.GenerateDataAnnotations,
                GenerateDefaultValues = settings.GenerateDefaultValues,
                GenerateImmutableArrayProperties = settings.GenerateImmutableArrayProperties,
                GenerateImmutableDictionaryProperties = settings.GenerateImmutableDictionaryProperties,
                GenerateJsonMethods = settings.GenerateJsonMethods,
                EnforceFlagEnums = settings.EnforceFlagEnums,
                ExcludedTypeNames = settings.ExcludedTypeNames,
                DictionaryInstanceType = settings.DictionaryInstanceType,
                DictionaryType = settings.DictionaryType,
                HandleReferences = settings.HandleReferences,
                InlineNamedAny = settings.InlineNamedAny,
                InlineNamedArrays = settings.InlineNamedArrays,
                InlineNamedDictionaries = settings.InlineNamedDictionaries,
                InlineNamedTuples = settings.InlineNamedTuples,
                RequiredPropertiesMustBeDefined = settings.RequiredPropertiesMustBeDefined,
                TypeAccessModifier = settings.TypeAccessModifier,
                PropertySetterAccessModifier = settings.PropertySetterAccessModifier,
                TimeType = settings.TimeType,
                TemplateDirectory = templateDirectoryPath,
                TimeSpanType = settings.TimeSpanType,
                JsonConverters = settings.JsonConverters,
                AnyType = settings.AnyType,
                ArrayBaseType = settings.ArrayBaseType,
                ArrayInstanceType = settings.ArrayInstanceType,
                ArrayType = settings.ArrayType,
                ClassStyle = settings.ClassStyle,
                DateTimeType = settings.DateTimeType,
                DateType = settings.DateType,
                DictionaryBaseType = settings.DictionaryBaseType,
                JsonLibrary = Enum.TryParse<CSharpJsonLibrary>(settings.JsonLibrary, true, out var jsonLibrary)
                    ? jsonLibrary
                    : CSharpJsonLibrary.NewtonsoftJson,
            },
            CodeGeneratorSettings =
            {
                ExcludedTypeNames = settings.ExcludedTypeNames,
                InlineNamedAny = settings.InlineNamedAny,
                GenerateDefaultValues = settings.GenerateDefaultValues,
                TemplateDirectory = templateDirectoryPath,
                PropertyNameGenerator = new CSharpPropertyNameGenerator(),
            },
            UseBaseUrl = settings.UseBaseUrl,
            UseHttpClientCreationMethod = settings.UseHttpClientCreationMethod,
            UseHttpRequestMessageCreationMethod = settings.UseHttpRequestMessageCreationMethod,
            UseRequestAndResponseSerializationSettings = settings.UseRequestAndResponseSerializationSettings,
            WrapDtoExceptions = settings.WrapDtoExceptions,
            WrapResponseMethods = settings.WrapResponseMethods,
            WrapResponses = settings.WrapResponses,
            ParameterArrayType = settings.ParameterArrayType,
            ParameterDateFormat = settings.ParameterDateFormat,
            ParameterDateTimeFormat = settings.ParameterDateTimeFormat,
            ParameterDictionaryType = settings.ParameterDictionaryType,
            InjectHttpClient = settings.InjectHttpClient,
            QueryNullValue = settings.QueryNullValue,
            HttpClientType = settings.HttpClientType,
            ResponseArrayType = settings.ResponseArrayType,
            ResponseClass = settings.ResponseClass,
            ResponseDictionaryType = settings.ResponseDictionaryType,
            SerializeTypeInformation = settings.SerializeTypeInformation,
            ExposeJsonSerializerSettings = settings.ExposeJsonSerializerSettings,
            ExcludedParameterNames = settings.ExcludedParameterNames,
            GenerateOptionalParameters = settings.GenerateOptionalParameters,
            GenerateBaseUrlProperty = settings.GenerateBaseUrlProperty,
            GenerateClientClasses = settings.GenerateClientClasses,
            GenerateClientInterfaces = settings.GenerateClientInterfaces,
            GenerateDtoTypes = settings.GenerateDtoTypes,
            GenerateExceptionClasses = settings.GenerateExceptionClasses,
            GeneratePrepareRequestAndProcessResponseAsAsyncMethods = settings.GeneratePrepareRequestAndProcessResponseAsAsyncMethods,
            GenerateResponseClasses = settings.GenerateResponseClasses,
            GenerateSyncMethods = settings.GenerateSyncMethods,
            GenerateUpdateJsonSerializerSettingsMethod = settings.GenerateUpdateJsonSerializerSettingsMethod,
        });

        return generator.GenerateFile();
    }

    #endregion
}
