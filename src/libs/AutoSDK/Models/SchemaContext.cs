using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Naming.Models;
using AutoSDK.Naming.Properties;
using Microsoft.OpenApi;

namespace AutoSDK.Models;

public class SchemaContext(
    Settings settings,
    IOpenApiSchema schema,
    string id,
    string type)
{
    public SchemaContext? Parent { get; set; }
    public IList<SchemaContext> Children { get; set; } = [];

    public Settings Settings { get; set; } = settings;
    public IOpenApiSchema Schema { get; set; } = schema;
    public string Id { get; set; } = id;
    public string Type { get; set; } = type;
    
    public string? ReferenceId { get; set; }
    public bool IsReference => ReferenceId != null;
    public SchemaContext? ResolvedReference { get; set; }
    
    public IList<SchemaContext> Links { get; set; } = [];
    
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

#if NET
    // Diagnostic counters for ComputeNodeData optimization
    [ThreadStatic] public static int ComputeNodeDataCalls;
    [ThreadStatic] public static int ComputeNodeDataHashSkips;
#endif

    /// <summary>
    /// True if this schema is part of a circular reference chain.
    /// Set during cycle detection after reference resolution.
    /// </summary>
    public bool IsInCycle { get; set; }
    
    public bool IsClass =>
        Type == "class" ||
        IsDerivedClass;// || ResolvedReference?.IsClass == true;
    private ModelData? _classData;
    private bool _classDataComputed;
    public ModelData? ClassData
    {
        get
        {
            if (!_classDataComputed)
            {
                _classData = IsClass ? ModelData.FromSchemaContext(this) : null;
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
                _enumData = IsEnum ? ModelData.FromSchemaContext(this) : null;
                _enumDataComputed = true;
            }
            return _enumData;
        }
    }
    public string? ClassName { get; set; }
    
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
                Parent?.Children.Any(x => x.PropertyName == PropertyName + "name") != true)
            {
                return
                [
                    PropertyData.Value,
                    PropertyData.Value with
                    {
                        Id = PropertyData.Value.Id + "name",
                        Name = PropertyData.Value.Name + "name",
                        IsMultiPartFormDataFilename = true,
                        Type = TypeData.Default with
                        {
                            CSharpTypeRaw = "string",
                            CSharpTypeNullability = !PropertyData.Value.IsRequired,
                            Settings = Settings,
                        },
                        Settings = Settings,
                    }
                ];
            }

            return [PropertyData.Value];
        }
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
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        var referenceId = schema.GetReferenceId();
        if (referenceId != null &&
            componentId != referenceId)
        {
            return [new SchemaContext(
                settings,
                schema,
                id: referenceId.ToCSharpName(settings, parent),
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
            }];
        }
        
        var context = new SchemaContext(
            settings,
            schema,
            id: ModelNameGenerator.ComputeId(settings, parent, hint, operation, parameter, propertyName, componentId, index, title: schema.Title),
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
        
        var children = new List<SchemaContext>();
        if (schema.Items != null)
        {
            children.AddRange(FromSchema(
                schema: schema.Items,
                settings: settings,
                parent: context,
                hint: Models.Hint.ArrayItem,
                depth: depth + 1));
        }
        if (schema.AdditionalProperties != null)
        {
            children.AddRange(FromSchema(
                schema: schema.AdditionalProperties,
                settings: settings,
                parent: context,
                hint: Models.Hint.AdditionalProperties,
                depth: depth + 1));
        }
        
        var i = 0;
        foreach (var property in (schema.Properties ?? new Dictionary<string, IOpenApiSchema>())
            .Where(x => x.Value != null))
        {
            children.AddRange(FromSchema(
                schema: property.Value,
                settings: settings,
                parent: context,
                hint: Models.Hint.Property,
                propertyName: property.Key,
                index: i++,
                depth: depth + 1));
        }

        i = 0;
        foreach (var item in schema.AnyOf ?? [])
        {
            children.AddRange(FromSchema(
                schema: item,
                settings: settings,
                parent: context,
                hint: Models.Hint.AnyOf,
                index: i++,
                depth: depth + 1));
        }
        i = 0;
        foreach (var item in schema.OneOf ?? [])
        {
            children.AddRange(FromSchema(
                schema: item,
                settings: settings,
                parent: context,
                hint: Models.Hint.OneOf,
                index: i++,
                depth: depth + 1));
        }
        i = 0;
        foreach (var item in schema.AllOf ?? [])
        {
            children.AddRange(FromSchema(
                schema: item,
                settings: settings,
                parent: context,
                hint: Models.Hint.AllOf,
                index: i++,
                depth: depth + 1));
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
            children.AddRange(FromSchema(
                schema: discriminatorSchema,
                settings: settings,
                parent: context,
                hint: Models.Hint.Discriminator,
                depth: depth + 1));
        }
        
        context.Children = children
            .Where(x => x.Depth == depth + 1)
            .ToList();
        
        // We need to fix name, so it doesn't conflict with real used name() and not to be handled as name conflict.
        if (schema.HasAllOfTypeForMetadata(propertyName: propertyName))
        {
            context.Id += "_AllOf1Wrapped";
        }
        
        return [context, ..children];
    }
    
    public bool ComputeData(int level = 0, int maxDepth = 20, HashSet<SchemaContext>? visited = null)
    {
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
            fullyComputed &= ResolvedReference.ComputeData(level + 1, maxDepth: maxDepth, visited: visited);
        }
        foreach (var child in Children)
        {
            fullyComputed &= child.ComputeData(level + 1, maxDepth: maxDepth, visited: visited);
        }

        // Only memoize if no subtree was cut short by depth/cycle limits
        _dataComputed = fullyComputed;

        ComputeNodeData();

        return fullyComputed;
    }

    /// <summary>
    /// Second pass for circular reference schemas: recompute data now that all
    /// TypeData is set from the first pass, then force-memoize.
    /// </summary>
    public void RecomputeDataIfNeeded()
    {
        if (_dataComputed)
        {
            return;
        }

        ComputeNodeData();
        _dataComputed = true;
    }

    private void ComputeNodeData()
    {
        // Skip recomputation if inputs (children/reference TypeData) haven't changed.
        // This avoids re-creating ImmutableArrays and record copies for cyclic schemas
        // whose dependencies produce the same TypeData across outer-loop iterations.
#if NET
        ComputeNodeDataCalls++;
#endif
        var inputsHash = ComputeInputsHash();
        if (TypeData != TypeData.Default && inputsHash == _lastInputsHash)
        {
#if NET
            ComputeNodeDataHashSkips++;
#endif
            return;
        }
        _lastInputsHash = inputsHash;

        TypeData = IsReference
            ? ResolvedReference?.TypeData ??
              throw new InvalidOperationException("Resolved reference must have type data.")
            : TypeData.FromSchemaContext(this);
        if (IsReference && ResolvedReference != null && TypeData != TypeData.Default)
        {
            TypeData = TypeData with
            {
                CSharpTypeRaw = TypeData.GetCSharpType(ResolvedReference),
                CSharpTypeNullability = TypeData.GetCSharpNullability(ResolvedReference, this),
            };
        }
        if (IsProperty)
        {
            PropertyData = Models.PropertyData.FromSchemaContext(this);
        }
        if (Hint is Models.Hint.Parameter)
        {
            ParameterData = MethodParameter.FromSchemaContext(this);
        }
        if (IsAnyOfLikeStructure && !TypeData.IsCollapsedAnyOfLike(this))
        {
            AnyOfData = global::AutoSDK.Models.AnyOfData.FromSchemaContext(this);
        }
    }

    /// <summary>
    /// Computes a hash of the inputs that determine this schema's TypeData:
    /// children TypeData and resolved reference TypeData. Used to skip
    /// redundant ComputeNodeData calls when inputs haven't changed.
    /// </summary>
    private int ComputeInputsHash()
    {
        var hash = new HashCode();
        if (ResolvedReference != null)
        {
            hash.Add(ResolvedReference.TypeData.GetHashCode());
        }
        for (var i = 0; i < Children.Count; i++)
        {
            hash.Add(Children[i].TypeData.GetHashCode());
        }
        return hash.ToHashCode();
    }

    public bool HasAnyTag(params string[] tags)
    {
        return
            tags.Contains(string.Empty) && Tags.Count == 0 ||
            Tags.Any(tags.Contains) ||
            Parent?.HasAnyTag(tags) == true;
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
        foreach (var tag in parentTags ?? [])
        {
            Tags.Add(tag);
        }

        foreach (var child in Children)
        {
            child.ComputeTags(Tags, level + 1, maxDepth: maxDepth, visited: visited);
        }
        ResolvedReference?.ComputeTags(Tags, level + 1, maxDepth: maxDepth, visited: visited);

        _tagsComputed = true;
    }
}
