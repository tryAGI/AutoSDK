using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using Microsoft.OpenApi;

namespace AutoSDK.Models;

public class SchemaContext(
    SchemaContextSettings settings,
    IOpenApiSchema schema,
    string id,
    string type)
{
    public SchemaContext? Parent { get; set; }
    public IList<SchemaContext> Children { get; set; } = Array.Empty<SchemaContext>();

    public SchemaContextSettings Settings { get; set; } = settings;
    public IOpenApiSchema Schema { get; set; } = schema;
    public string Id { get; set; } = id;
    public string Type { get; set; } = type;
    
    public string? ReferenceId { get; set; }
    public bool IsReference => ReferenceId != null;
    public SchemaContext? ResolvedReference { get; set; }
    
    private IList<SchemaContext>? _links;
    public IList<SchemaContext> Links
    {
        get => _links ??= [];
        set => _links = value;
    }
    
    public Hint? Hint { get; set; }
    public int? Index { get; set; }
    /// <summary>
    /// Used to constrain the recursion depth.
    /// </summary>
    public int Depth { get; set; }
    
    public string? PropertyName { get; set; }
    public bool IsProperty => PropertyName != null;
    public PropertyData? PropertyData { get; set; }
    
    public string? ParameterName => Parameter?.Name;
    public bool IsParameter => ParameterName != null;
    public MethodParameter? ParameterData { get; set; }
    
    public string? ComponentId { get; set; }
    public bool IsComponent => ComponentId != null || ResolvedReference?.IsComponent == true;
    
    public string? OperationPath { get; set; }
    public System.Net.Http.HttpMethod? OperationType { get; set; }
    public OpenApiOperation? Operation { get; set; }
    public string? ContentType { get; set; }
    public IOpenApiMediaType? MediaType { get; set; }
    public IOpenApiParameter? Parameter { get; set; }
    public string? ResponseStatusCode { get; set; }
    public IOpenApiResponse? Response { get; set; }
    public bool IsOperation => OperationPath != null;
    
    public TypeData TypeData { get; set; } = TypeData.Default;
    private bool _dataComputed;
    private bool _tagsComputed;
    private int _lastInputsHash;

    /// <summary>
    /// True if this schema is part of a circular reference chain.
    /// Set during cycle detection after reference resolution.
    /// </summary>
    public bool IsInCycle { get; set; }

    /// <summary>
    /// Cached result of <see cref="OpenApiExtensions.HasAllOfTypeForMetadata(SchemaContext)"/>.
    /// Computed once to avoid repeated access to IOpenApiSchema property accessors.
    /// </summary>
    private bool? _isAllOfForMetadata;
    public bool IsAllOfForMetadata => _isAllOfForMetadata ??= this.HasAllOfTypeForMetadata();
    
    public bool IsClass =>
        Type == "class" ||
        IsDerivedClass;// || ResolvedReference?.IsClass == true;
    private ModelData? _classData;
    private bool _classDataComputed;
    public Func<SchemaContext, ModelData>? ModelDataFactory { get; set; }
    public ModelData? ClassData
    {
        get
        {
            if (!_classDataComputed)
            {
                _classData = IsClass
                    ? ModelDataFactory?.Invoke(this) ?? throw new InvalidOperationException("ModelDataFactory is not initialized.")
                    : null;
                _classDataComputed = true;
            }
            return _classData;
        }
    }

    public bool IsEnum => Type == "enum";// || ResolvedReference?.IsEnum == true;
    private ModelData? _enumData;
    private bool _enumDataComputed;
    public ModelData? EnumData
    {
        get
        {
            if (!_enumDataComputed)
            {
                _enumData = IsEnum
                    ? ModelDataFactory?.Invoke(this) ?? throw new InvalidOperationException("ModelDataFactory is not initialized.")
                    : null;
                _enumDataComputed = true;
            }
            return _enumData;
        }
    }
    public string? ClassName { get; set; }

    /// <summary>
    /// Cached unsanitized class name from ComputeClassName (before SanitizeName).
    /// Used to avoid recursive recomputation of parent class names.
    /// </summary>
    public string? CachedComputedClassName { get; set; }

    public AnyOfData? AnyOfData { get; set; }
    public string? VariantName { get; set; }
    
    public bool IsModel => IsClass || IsEnum || IsAnyOfLikeStructure && IsComponent;
    
    public bool IsAnyOf => Schema.IsAnyOf();
    public bool IsOneOf => Schema.IsOneOf();
    public bool IsAllOf => Schema.IsAllOf() && !IsDerivedClass;
    public bool IsBaseClass => this is { IsComponent: true, Schema.Discriminator.Mapping: not null };
    public bool IsDerivedClass => Schema.IsAllOf() &&
                                  Schema.AllOf is { Count: 2 } allOf &&
                                  (allOf[0].IsSchemaReference() &&
                                  allOf[0].ResolveIfRequired().Discriminator?.Mapping != null ||
                                  allOf[1].IsSchemaReference() &&
                                  allOf[1].ResolveIfRequired().Discriminator?.Mapping != null);
    public SchemaContext DerivedClassContext =>
        Schema.IsAllOf() &&
        Schema.AllOf is { Count: 2 } allOf
        ? allOf[0].IsSchemaReference() &&
          allOf[0].ResolveIfRequired().Discriminator?.Mapping != null
            ? Children.First(x => x.ReferenceId == allOf[1].GetReferenceId())
            : Children.First(x => x.ReferenceId == allOf[0].GetReferenceId())
            : throw new InvalidOperationException("Schema is not derived class.");

    public SchemaContext BaseClassContext =>
        Schema.IsAllOf() &&
        Schema.AllOf is { Count: 2 } allOf
        ? allOf[0].IsSchemaReference() &&
          allOf[0].ResolveIfRequired().Discriminator?.Mapping != null
            ? Children.First(x => x.ReferenceId == allOf[0].GetReferenceId())
            : Children.First(x => x.ReferenceId == allOf[1].GetReferenceId())
            : throw new InvalidOperationException("Schema is not derived class.");
    
    public bool IsAnyOfLikeStructure => IsAnyOf || IsOneOf || IsAllOf;
    public bool IsNamedAnyOfLike => IsAnyOfLikeStructure &&
                                    (IsComponent || Schema.Discriminator != null);
    
    public IReadOnlyList<PropertyData> ComputedProperties
    {
        get
        {
            if (PropertyData == null)
            {
                return [];
            }

            if (Schema.IsBinary() &&
                !HasSiblingPropertyWithSuffix("name"))
            {
                return
                [
                    PropertyData.Value,
                    PropertyData.Value with
                    {
                        Id = PropertyData.Value.Id + "name",
                        Name = PropertyData.Value.Name + "name",
                        ParameterName = PropertyData.Value.ParameterName + "name",
                        IsMultiPartFormDataFilename = true,
                        Type = TypeData.Default with
                        {
                            CSharpTypeRaw = "string",
                            CSharpTypeNullability = !PropertyData.Value.IsRequired,
                            Namespace = Settings.Namespace,
                            GeneratedNamespace = Settings.Namespace,
                            CSharpTypeWithoutNullability = "string",
                            CSharpTypeWithNullability = "string?",
                            ShortCSharpTypeWithoutNullability = "string",
                            ShortCSharpTypeWithNullability = "string?",
                            IsAnyOfLike = false,
                            CSharpTypeWithNullabilityForValueTypes = "string",
                            CSharpTypeWithNullabilityForNonValueTypes = "string?",
                            CSharpType = !PropertyData.Value.IsRequired ? "string?" : "string",
                            IsReferenceable = true,
                            ConverterType = string.Empty,
                        },
                        Settings = Settings.ToEmitterSettings(),
                    }
                ];
            }

            return [PropertyData.Value];
        }
    }

    private bool HasSiblingPropertyWithSuffix(string suffix)
    {
        if (Parent == null || PropertyName == null) return false;

        var targetName = PropertyName + suffix;
        var siblings = Parent.Children;
        // Check 1: Exact JSON property name match
        for (var i = 0; i < siblings.Count; i++)
        {
            if (siblings[i].PropertyName == targetName)
            {
                return true;
            }
        }
        // Check 2: Case-insensitive C# property name collision
        // Catches cases like file_name (FileName) vs synthetic filename (Filename)
        if (PropertyData != null)
        {
            var syntheticCSharpName = PropertyData.Value.Name + suffix;
            for (var i = 0; i < siblings.Count; i++)
            {
                var sibling = siblings[i];
                if (sibling == this || sibling.PropertyData == null) continue;
                if (string.Equals(sibling.PropertyData.Value.Name, syntheticCSharpName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public HashSet<string> Tags { get; set; } = [];
    
    private static string ComputeType(IOpenApiSchema schema, bool isComponent)
    {
        if (schema.IsEnum())
        {
            return "enum";
        }
        // Check if Object flag is set (handles nullable types like ["object", "null"])
        if (schema.Type != null && (schema.Type & JsonSchemaType.Object) == JsonSchemaType.Object)
        {
            return "class";
        }
        if (schema.IsBoolean())
        {
            return "bool";
        }
        // Check if Number flag is set (handles nullable types like ["number", "null"])
        if (schema.Type != null && (schema.Type & JsonSchemaType.Number) == JsonSchemaType.Number)
        {
            return schema.Format switch
            {
                "float" => "float",
                _ => "double",
            };
        }
        // Check if Integer flag is set (handles nullable types like ["integer", "null"])
        if (schema.Type != null && (schema.Type & JsonSchemaType.Integer) == JsonSchemaType.Integer)
        {
            return schema.Format switch
            {
                "int64" => "long",
                _ => "int",
            };
        }

        // Check if String flag is set (handles nullable types like ["string", "null"])
        if (schema.Type != null && (schema.Type & JsonSchemaType.String) == JsonSchemaType.String)
        {
            return schema.Format switch
            {
                "byte" => "byte",
                "binary" => "byte[]",
                "date" => "DateTime",
                "date-time" => "DateTime",
                "uri" => "Uri",
                _ => "string",
            };
        }
        if (schema.IsAnyOf())
        {
            return "anyOf";
        }
        if (schema.IsOneOf())
        {
            return "oneOf";
        }
        if (schema.IsAllOf())
        {
            return "allOf";
        }

        return schema.Type.ToTypeString() ?? "class";
    }

    public bool IsRequired =>
        IsProperty && PropertyName != null && (Parent?.Schema.Required?.Contains(PropertyName) ?? false) ||
        Hint == Models.Hint.Parameter && Parameter?.Required == true ||
        Hint == Models.Hint.Request && Operation?.RequestBody?.Required == true ||
        Hint == Models.Hint.Response ||
        Hint == Models.Hint.AdditionalProperties;

    public static IReadOnlyList<SchemaContext> FromSchema(
        IOpenApiSchema schema,
        Settings settings,
        Func<ReferenceNameContext, string> referenceIdFactory,
        Func<SchemaNameContext, string> schemaIdFactory,
        SchemaContext? parent = null,
        string? componentId = null,
        string? propertyName = null,
        string? operationPath = null,
        System.Net.Http.HttpMethod? operationType = null,
        OpenApiOperation? operation = null,
        string? contentType = null,
        IOpenApiMediaType? mediaType = null,
        IOpenApiParameter? parameter = null,
        string? responseStatusCode = null,
        IOpenApiResponse? response = null,
        Hint? hint = null,
        int? index = null,
        int depth = 0)
    {
        return FromSchema(
            schema,
            settings.ToSchemaContextSettings(),
            referenceIdFactory,
            schemaIdFactory,
            parent,
            componentId,
            propertyName,
            operationPath,
            operationType,
            operation,
            contentType,
            mediaType,
            parameter,
            responseStatusCode,
            response,
            hint,
            index,
            depth);
    }

    public static IReadOnlyList<SchemaContext> FromSchema(
        IOpenApiSchema schema,
        SchemaContextSettings settings,
        Func<ReferenceNameContext, string> referenceIdFactory,
        Func<SchemaNameContext, string> schemaIdFactory,
        SchemaContext? parent = null,
        string? componentId = null,
        string? propertyName = null,
        string? operationPath = null,
        System.Net.Http.HttpMethod? operationType = null,
        OpenApiOperation? operation = null,
        string? contentType = null,
        IOpenApiMediaType? mediaType = null,
        IOpenApiParameter? parameter = null,
        string? responseStatusCode = null,
        IOpenApiResponse? response = null,
        Hint? hint = null,
        int? index = null,
        int depth = 0)
    {
        referenceIdFactory = referenceIdFactory ?? throw new ArgumentNullException(nameof(referenceIdFactory));
        schemaIdFactory = schemaIdFactory ?? throw new ArgumentNullException(nameof(schemaIdFactory));

        var result = new List<SchemaContext>();
        FromSchemaCore(
            result, schema, settings, referenceIdFactory, schemaIdFactory, parent, componentId, propertyName,
            operationPath, operationType, operation, contentType, mediaType,
            parameter, responseStatusCode, response, hint, index, depth);
        return result;
    }

    internal static void FromSchemaCore(
        List<SchemaContext> result,
        IOpenApiSchema schema,
        SchemaContextSettings settings,
        Func<ReferenceNameContext, string> referenceIdFactory,
        Func<SchemaNameContext, string> schemaIdFactory,
        SchemaContext? parent,
        string? componentId,
        string? propertyName,
        string? operationPath,
        System.Net.Http.HttpMethod? operationType,
        OpenApiOperation? operation,
        string? contentType,
        IOpenApiMediaType? mediaType,
        IOpenApiParameter? parameter,
        string? responseStatusCode,
        IOpenApiResponse? response,
        Hint? hint,
        int? index,
        int depth)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        var referenceId = schema.GetReferenceId();
        if (referenceId != null &&
            componentId != referenceId)
        {
            var namingSettings = settings.ToSchemaNamingSettings();
            result.Add(new SchemaContext(
                settings,
                schema,
                id: referenceIdFactory(new ReferenceNameContext(
                    namingSettings,
                    parent,
                    referenceId)),
                type: "ref")
            {
                Parent = parent,
                ReferenceId = referenceId,
                ComponentId = componentId,
                PropertyName = propertyName,
                Hint = hint,
                Index = index,
                OperationPath = operationPath,
                OperationType = operationType,
                Operation = operation,
                ContentType = contentType,
                MediaType = mediaType,
                Parameter = parameter,
                ResponseStatusCode = responseStatusCode,
                Response = response,
                Depth = depth,
            });
            return;
        }

        var schemaNamingSettings = settings.ToSchemaNamingSettings();
        var context = new SchemaContext(
            settings,
            schema,
            id: schemaIdFactory(new SchemaNameContext(
                schemaNamingSettings,
                parent,
                hint,
                operation,
                parameter,
                propertyName,
                componentId,
                index,
                schema.Title,
                operationPath,
                operationType)),
            type: ComputeType(schema, isComponent: componentId != null))
        {
            Parent = parent,
            ComponentId = componentId,
            PropertyName = propertyName,
            Hint = hint,
            Index = index,
            OperationPath = operationPath,
            OperationType = operationType,
            Operation = operation,
            ContentType = contentType,
            MediaType = mediaType,
            Parameter = parameter,
            ResponseStatusCode = responseStatusCode,
            Response = response,
            Depth = depth,
        };

        // Track where children start in the result list
        var childrenStart = result.Count;
        result.Add(context);

        if (schema.Items != null)
        {
            FromSchemaCore(
                result, schema.Items, settings, referenceIdFactory, schemaIdFactory, context, componentId: null,
                propertyName: null, operationPath: null, operationType: null,
                operation: null, contentType: null, mediaType: null,
                parameter: null, responseStatusCode: null, response: null,
                hint: Models.Hint.ArrayItem, index: null, depth: depth + 1);
        }
        if (schema.AdditionalProperties != null)
        {
            FromSchemaCore(
                result, schema.AdditionalProperties, settings, referenceIdFactory, schemaIdFactory, context, componentId: null,
                propertyName: null, operationPath: null, operationType: null,
                operation: null, contentType: null, mediaType: null,
                parameter: null, responseStatusCode: null, response: null,
                hint: Models.Hint.AdditionalProperties, index: null, depth: depth + 1);
        }

        var i = 0;
        var properties = schema.Properties;
        if (properties != null)
        {
            foreach (var property in properties)
            {
                if (property.Value != null)
                {
                    FromSchemaCore(
                        result, property.Value, settings, referenceIdFactory, schemaIdFactory, context, componentId: null,
                        propertyName: property.Key, operationPath: null, operationType: null,
                        operation: null, contentType: null, mediaType: null,
                        parameter: null, responseStatusCode: null, response: null,
                        hint: Models.Hint.Property, index: i++, depth: depth + 1);
                }
            }
        }

        i = 0;
        if (schema.AnyOf != null)
        {
            foreach (var item in schema.AnyOf)
            {
                FromSchemaCore(
                    result, item, settings, referenceIdFactory, schemaIdFactory, context, componentId: null,
                    propertyName: null, operationPath: null, operationType: null,
                    operation: null, contentType: null, mediaType: null,
                    parameter: null, responseStatusCode: null, response: null,
                    hint: Models.Hint.AnyOf, index: i++, depth: depth + 1);
            }
        }
        i = 0;
        if (schema.OneOf != null)
        {
            foreach (var item in schema.OneOf)
            {
                FromSchemaCore(
                    result, item, settings, referenceIdFactory, schemaIdFactory, context, componentId: null,
                    propertyName: null, operationPath: null, operationType: null,
                    operation: null, contentType: null, mediaType: null,
                    parameter: null, responseStatusCode: null, response: null,
                    hint: Models.Hint.OneOf, index: i++, depth: depth + 1);
            }
        }
        i = 0;
        if (schema.AllOf != null)
        {
            foreach (var item in schema.AllOf)
            {
                FromSchemaCore(
                    result, item, settings, referenceIdFactory, schemaIdFactory, context, componentId: null,
                    propertyName: null, operationPath: null, operationType: null,
                    operation: null, contentType: null, mediaType: null,
                    parameter: null, responseStatusCode: null, response: null,
                    hint: Models.Hint.AllOf, index: i++, depth: depth + 1);
            }
        }

        if (schema.Discriminator != null && schema.Discriminator.PropertyName != null &&
            (schema.IsOneOf() || schema.IsAnyOf() || schema.IsAllOf() ||
             schema.Discriminator.Mapping is { Count: > 0 }))
        {
            var discriminatorSchema = new OpenApiSchema
            {
                Type = JsonSchemaType.Object,
                Properties = new Dictionary<string, IOpenApiSchema>
                {
                    [schema.Discriminator.PropertyName] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.String,
                        Enum = schema.Discriminator.Mapping?.Keys
                            .Select(x => JsonValue.Create(x))
                            .OfType<JsonNode>()
                            .ToList() ?? [],
                    }
                }
            };
            FromSchemaCore(
                result, discriminatorSchema, settings, referenceIdFactory, schemaIdFactory, context,
                componentId: null, propertyName: null, operationPath: null,
                operationType: null, operation: null, contentType: null,
                mediaType: null, parameter: null, responseStatusCode: null,
                response: null, hint: Models.Hint.Discriminator, index: null,
                depth: depth + 1);
        }

        // Build direct children list from the accumulated results (only depth+1 descendants)
        // Count first to pre-allocate exactly
        var childDepth = depth + 1;
        var childCount = 0;
        for (var j = childrenStart + 1; j < result.Count; j++)
        {
            if (result[j].Depth == childDepth) childCount++;
        }
        var directChildren = new List<SchemaContext>(childCount);
        for (var j = childrenStart + 1; j < result.Count; j++)
        {
            if (result[j].Depth == childDepth)
            {
                directChildren.Add(result[j]);
            }
        }
        context.Children = directChildren;

        // We need to fix name, so it doesn't conflict with real used name() and not to be handled as name conflict.
        if (schema.HasAllOfTypeForMetadata(propertyName: propertyName))
        {
            context.Id += "_AllOf1Wrapped";
        }
    }
    
    public bool ComputeData(
        Func<SchemaContext, ModelData> modelDataFactory,
        Func<SchemaContext, TypeData> typeDataFactory,
        Func<TypeData, TypeData> typeDataNormalizer,
        Func<SchemaContext, string> typeRawFactory,
        Func<SchemaContext, SchemaContext?, bool> typeNullabilityFactory,
        Func<SchemaContext, PropertyData> propertyDataFactory,
        Func<SchemaContext, MethodParameter> parameterDataFactory,
        Func<SchemaContext, AnyOfData> anyOfDataFactory,
        int level = 0,
        int maxDepth = 20,
        HashSet<SchemaContext>? visited = null)
    {
        modelDataFactory = modelDataFactory ?? throw new ArgumentNullException(nameof(modelDataFactory));
        typeDataFactory = typeDataFactory ?? throw new ArgumentNullException(nameof(typeDataFactory));
        typeDataNormalizer = typeDataNormalizer ?? throw new ArgumentNullException(nameof(typeDataNormalizer));
        typeRawFactory = typeRawFactory ?? throw new ArgumentNullException(nameof(typeRawFactory));
        typeNullabilityFactory = typeNullabilityFactory ?? throw new ArgumentNullException(nameof(typeNullabilityFactory));
        propertyDataFactory = propertyDataFactory ?? throw new ArgumentNullException(nameof(propertyDataFactory));
        parameterDataFactory = parameterDataFactory ?? throw new ArgumentNullException(nameof(parameterDataFactory));
        anyOfDataFactory = anyOfDataFactory ?? throw new ArgumentNullException(nameof(anyOfDataFactory));
        ModelDataFactory = modelDataFactory;

        // Skip if already fully computed (memoization across all callers)
        if (_dataComputed)
        {
            return true;
        }

        // Prevent infinite recursion for circular references
        if (level > maxDepth)
        {
            return false;
        }

        visited ??= new HashSet<SchemaContext>();
        if (!visited.Add(this))
        {
            return false;
        }

        var fullyComputed = true;
        if (ResolvedReference != null)
        {
            fullyComputed &= ResolvedReference.ComputeData(
                modelDataFactory,
                typeDataFactory,
                typeDataNormalizer,
                typeRawFactory,
                typeNullabilityFactory,
                propertyDataFactory,
                parameterDataFactory,
                anyOfDataFactory,
                level + 1,
                maxDepth: maxDepth,
                visited: visited);
        }
        foreach (var child in Children)
        {
            fullyComputed &= child.ComputeData(
                modelDataFactory,
                typeDataFactory,
                typeDataNormalizer,
                typeRawFactory,
                typeNullabilityFactory,
                propertyDataFactory,
                parameterDataFactory,
                anyOfDataFactory,
                level + 1,
                maxDepth: maxDepth,
                visited: visited);
        }

        // Only memoize if no subtree was cut short by depth/cycle limits
        _dataComputed = fullyComputed;

        ComputeNodeData(
            typeDataFactory,
            typeDataNormalizer,
            typeRawFactory,
            typeNullabilityFactory,
            propertyDataFactory,
            parameterDataFactory,
            anyOfDataFactory);

        return fullyComputed;
    }

    /// <summary>
    /// Second pass for circular reference schemas: recompute data now that all
    /// TypeData is set from the first pass, then force-memoize.
    /// </summary>
    public void RecomputeDataIfNeeded(
        Func<SchemaContext, ModelData> modelDataFactory,
        Func<SchemaContext, TypeData> typeDataFactory,
        Func<TypeData, TypeData> typeDataNormalizer,
        Func<SchemaContext, string> typeRawFactory,
        Func<SchemaContext, SchemaContext?, bool> typeNullabilityFactory,
        Func<SchemaContext, PropertyData> propertyDataFactory,
        Func<SchemaContext, MethodParameter> parameterDataFactory,
        Func<SchemaContext, AnyOfData> anyOfDataFactory)
    {
        modelDataFactory = modelDataFactory ?? throw new ArgumentNullException(nameof(modelDataFactory));
        typeDataFactory = typeDataFactory ?? throw new ArgumentNullException(nameof(typeDataFactory));
        typeDataNormalizer = typeDataNormalizer ?? throw new ArgumentNullException(nameof(typeDataNormalizer));
        typeRawFactory = typeRawFactory ?? throw new ArgumentNullException(nameof(typeRawFactory));
        typeNullabilityFactory = typeNullabilityFactory ?? throw new ArgumentNullException(nameof(typeNullabilityFactory));
        propertyDataFactory = propertyDataFactory ?? throw new ArgumentNullException(nameof(propertyDataFactory));
        parameterDataFactory = parameterDataFactory ?? throw new ArgumentNullException(nameof(parameterDataFactory));
        anyOfDataFactory = anyOfDataFactory ?? throw new ArgumentNullException(nameof(anyOfDataFactory));
        ModelDataFactory = modelDataFactory;

        if (_dataComputed)
        {
            return;
        }

        ComputeNodeData(
            typeDataFactory,
            typeDataNormalizer,
            typeRawFactory,
            typeNullabilityFactory,
            propertyDataFactory,
            parameterDataFactory,
            anyOfDataFactory);
        _dataComputed = true;
    }

    private void ComputeNodeData(
        Func<SchemaContext, TypeData> typeDataFactory,
        Func<TypeData, TypeData> typeDataNormalizer,
        Func<SchemaContext, string> typeRawFactory,
        Func<SchemaContext, SchemaContext?, bool> typeNullabilityFactory,
        Func<SchemaContext, PropertyData> propertyDataFactory,
        Func<SchemaContext, MethodParameter> parameterDataFactory,
        Func<SchemaContext, AnyOfData> anyOfDataFactory)
    {
        // Skip recomputation if inputs (children/reference TypeData) haven't changed.
        // This avoids re-creating ImmutableArrays and record copies for cyclic schemas
        // whose dependencies produce the same TypeData across outer-loop iterations.
        var inputsHash = ComputeInputsHash();
        if (TypeData != TypeData.Default && inputsHash == _lastInputsHash)
        {
            return;
        }
        _lastInputsHash = inputsHash;

        TypeData = IsReference
            ? ResolvedReference?.TypeData ??
              throw new InvalidOperationException("Resolved reference must have type data.")
            : typeDataFactory(this);
        if (IsReference && ResolvedReference != null && TypeData != TypeData.Default)
        {
            var newType = typeRawFactory(ResolvedReference);
            var newNullability = typeNullabilityFactory(ResolvedReference, this);
            if (newType != TypeData.CSharpTypeRaw || newNullability != TypeData.CSharpTypeNullability)
            {
                TypeData = TypeData with
                {
                    CSharpTypeRaw = newType,
                    CSharpTypeNullability = newNullability,
                };
                TypeData = typeDataNormalizer(TypeData);
            }
        }
        if (IsProperty)
        {
            PropertyData = propertyDataFactory(this);
        }
        if (Hint is Models.Hint.Parameter)
        {
            ParameterData = parameterDataFactory(this);
        }
        if (IsAnyOfLikeStructure && TypeData.IsAnyOfLike)
        {
            AnyOfData = anyOfDataFactory(this);
        }
    }

    /// <summary>
    /// Computes a hash of the inputs that determine this schema's TypeData:
    /// children TypeData and resolved reference TypeData. Used to skip
    /// redundant ComputeNodeData calls when inputs haven't changed.
    /// </summary>
    private int ComputeInputsHash()
    {
        // Use simple XOR+rotate instead of allocating HashCode struct per call.
        // Called ~61K times for large specs; this avoids per-call overhead.
        var h = 0;
        if (ResolvedReference != null)
        {
            h = ResolvedReference.TypeData.DependencyHash;
        }
        for (var i = 0; i < Children.Count; i++)
        {
            // Rotate left by 5 and XOR to mix bits
            h = ((h << 5) | (int)((uint)h >> 27)) ^ Children[i].TypeData.DependencyHash;
        }
        return h;
    }

    public bool HasAnyTag(params string[] tags)
    {
        tags = tags ?? throw new ArgumentNullException(nameof(tags));

        for (var i = 0; i < tags.Length; i++)
        {
            if (tags[i].Length == 0 && Tags.Count == 0)
            {
                return true;
            }
            if (Tags.Contains(tags[i]))
            {
                return true;
            }
        }
        return Parent?.HasAnyTag(tags) == true;
    }
    
    public bool AnyParent(Func<SchemaContext, bool> predicate)
    {
        predicate = predicate ?? throw new ArgumentNullException(nameof(predicate));
        
        if (predicate(this))
        {
            return true;
        }
        
        return Parent?.AnyParent(predicate) == true;
    }
    
    /// <summary>
    /// Adds this schema and all its children to the target set without intermediate List allocations.
    /// </summary>
    public void CollectWithAllChildren(
        HashSet<SchemaContext> target,
        Predicate<SchemaContext>? shouldExpandReference = null,
        int level = 0,
        int maxDepth = 20)
    {
        target = target ?? throw new ArgumentNullException(nameof(target));

        if (level > maxDepth || !target.Add(this))
        {
            return;
        }

        if (IsReference)
        {
            if (ResolvedReference is { } resolvedReference &&
                (shouldExpandReference == null || shouldExpandReference(resolvedReference)))
            {
                resolvedReference.CollectWithAllChildren(target, shouldExpandReference, level + 1, maxDepth);
            }
            return;
        }

        for (var i = 0; i < Children.Count; i++)
        {
            Children[i].CollectWithAllChildren(target, shouldExpandReference, level + 1, maxDepth);
        }
    }

    public IReadOnlyCollection<SchemaContext> WithAllChildren(int level = 0, int maxDepth = 20, HashSet<SchemaContext>? visited = null)
    {
        // Prevent infinite recursion for circular references
        if (level > maxDepth)
        {
            return [];
        }

        visited ??= [];
        if (!visited.Add(this))
        {
            return [];
        }

        if (IsReference)
        {
            return ResolvedReference == null
                ? []
                : [this, ..ResolvedReference.WithAllChildren(level + 1, maxDepth: maxDepth, visited: visited)];
        }

        var result = new List<SchemaContext> { this };
        foreach (var child in Children)
        {
            result.AddRange(child.WithAllChildren(level + 1, maxDepth: maxDepth, visited: visited));
        }

        return result;
    }
    
    public void ComputeTags(HashSet<string>? parentTags = null, int level = 0, int maxDepth = 20, HashSet<SchemaContext>? visited = null)
    {
        // Skip if already computed and no new parent tags to add
        if (_tagsComputed && (parentTags == null || parentTags.Count == 0 || parentTags.IsSubsetOf(Tags)))
        {
            return;
        }

        // Prevent infinite recursion for circular references
        if (level > maxDepth)
        {
            return;
        }

        visited ??= new HashSet<SchemaContext>();
        if (!visited.Add(this))
        {
            return;
        }

        if (Operation?.Tags != null)
        {
            foreach (var tag in Operation.Tags)
            {
                if (tag.Name != null)
                {
                    Tags.Add(tag.Name);
                }
            }
        }
        if (parentTags != null)
        {
            foreach (var tag in parentTags)
            {
                Tags.Add(tag);
            }
        }

        foreach (var child in Children)
        {
            child.ComputeTags(Tags, level + 1, maxDepth: maxDepth, visited: visited);
        }
        ResolvedReference?.ComputeTags(Tags, level + 1, maxDepth: maxDepth, visited: visited);

        _tagsComputed = true;
    }
}
