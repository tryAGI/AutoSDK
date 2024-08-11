using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Naming.Models;

namespace OpenApiGenerator.Core.Models;

public class SchemaContext
{
    public SchemaContext? Parent { get; init; }
    public IList<SchemaContext> Children { get; set; } = [];
    
    public required Settings Settings { get; init; }
    public required OpenApiSchema Schema { get; init; }
    public required string Id { get; set; }
    public required string Type { get; init; }
    
    public string? ReferenceId { get; init; }
    public bool IsReference => ReferenceId != null;
    public SchemaContext? ResolvedReference { get; set; }
    
    public Hint? Hint { get; init; }
    public int? Index { get; init; }
    /// <summary>
    /// Used to constrain the recursion depth.
    /// </summary>
    public int Depth { get; init; }
    
    public string? PropertyName { get; init; }
    public bool IsProperty => PropertyName != null;
    public PropertyData? PropertyData { get; set; }
    
    public string? ComponentId { get; init; }
    public bool IsComponent => ComponentId != null || ResolvedReference?.IsComponent == true;
    
    public string? OperationPath { get; init; }
    public OperationType? OperationType { get; init; }
    public OpenApiOperation? Operation { get; init; }
    public string? ContentType { get; init; }
    public OpenApiMediaType? MediaType { get; init; }
    public OpenApiParameter? Parameter { get; init; }
    public string? ParameterName => Parameter?.Name;
    public string? ResponseStatusCode { get; init; }
    public OpenApiResponse? Response { get; init; }
    public bool IsOperation => OperationPath != null;
    
    public TypeData? TypeData { get; set; }
    
    public bool IsClass => Type == "class";// || ResolvedReference?.IsClass == true;
    //public ModelData? ClassData { get; set; }
    public ModelData? ClassData => IsClass
        ? //IsReference
            //? ModelData.FromSchemaContext(ResolvedReference!)
            //:
            ModelData.FromSchemaContext(this)
        : null;
    
    public bool IsEnum => Type == "enum";// || ResolvedReference?.IsEnum == true;
    //public ModelData? EnumData { get; set; }
    public ModelData? EnumData => IsEnum
         ? //IsReference
             //? ModelData.FromSchemaContext(ResolvedReference!)
             //:
             ModelData.FromSchemaContext(this)
         : null;
    public string? ClassName { get; set; }
    
    public bool IsModel => IsClass || IsEnum || IsAnyOfLikeStructure && IsComponent;
    
    public bool IsAnyOf => Schema.IsAnyOf();
    public bool IsOneOf => Schema.IsOneOf();
    public bool IsAllOf => Schema.IsAllOf();
    public bool IsAnyOfLikeStructure => IsAnyOf || IsOneOf || IsAllOf;
    
    public IReadOnlyList<PropertyData> ComputedProperties
    {
        get
        {
            if (PropertyData == null)
            {
                return [];
            }
            
            if (Schema.IsBinary())
            {
                return new []
                {
                    PropertyData.Value,
                    PropertyData.Value with
                    {
                        Id = PropertyData.Value.Id + "name",
                        Name = PropertyData.Value.Name + "name",
                        IsMultiPartFormDataFilename = true,
                        Type = Models.TypeData.Default with
                        {
                            CSharpType = PropertyData.Value.IsRequired ? "string" : "string?",
                            JsonSerializerType = Settings.JsonSerializerType,
                            GenerateJsonSerializerContextTypes = Settings.GenerateJsonSerializerContextTypes,
                        },
                        JsonSerializerType = Settings.JsonSerializerType,
                    },
                };
            }

            return new [] { PropertyData.Value };
        }
    }

    public HashSet<string> Tags { get; set; } = [];
    
    private static string ComputeType(OpenApiSchema schema)
    {
        if (schema.IsEnum())
        {
            return "enum";
        }
        if (schema.Type == "object")
        {
            return "class";
        }
        if (schema.Type == "boolean")
        {
            return "bool";
        }
        if (schema.Type == "number")
        {
            return schema.Format switch
            {
                "float" => "float",
                _ => "double",
            };
        }
        if (schema.Type == "integer")
        {
            return schema.Format switch
            {
                "int64" => "long",
                _ => "int",
            };
        }

        if (schema.Type == "string")
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
        
        return schema.Type ?? "class";
    }

    public string ShortType => TypeData?.CSharpType ?? Type;

    public bool IsRequired =>
        IsProperty && Parent?.Schema.Required.Contains(PropertyName) == true ||
        Hint == Models.Hint.Parameter && Parameter?.Required == true ||
        Hint == Models.Hint.Request && Operation?.RequestBody?.Required == true ||
        Hint == Models.Hint.Response;

    public static IReadOnlyList<SchemaContext> FromSchema(
        OpenApiSchema schema,
        Settings settings,
        SchemaContext? parent = null,
        string? componentId = null,
        string? propertyName = null,
        string? operationPath = null,
        OperationType? operationType = null,
        OpenApiOperation? operation = null,
        string? contentType = null,
        OpenApiMediaType? mediaType = null,
        OpenApiParameter? parameter = null,
        string? responseStatusCode = null,
        OpenApiResponse? response = null,
        Hint? hint = null,
        int? index = null,
        int depth = 0)
    {
        schema = schema ?? throw new ArgumentNullException(nameof(schema));

        if (schema.Reference?.Id != null &&
            componentId != schema.Reference.Id)
        {
            return [new SchemaContext
            {
                Parent = parent,
                Settings = settings,
                Schema = schema,
                Id = schema.Reference.Id.ToCSharpName(settings, parent),
                Type = "ref",
                ReferenceId = schema.Reference.Id,
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
        
        var context = new SchemaContext
        {
            Parent = parent,
            Settings = settings,
            Schema = schema,
            Id = ModelNameGenerator.ComputeId(settings, parent, hint, operation, parameter, propertyName, componentId, index),
            Type = ComputeType(schema),
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
        
        var i = 0;
        foreach (var property in schema.Properties)
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
        foreach (var item in schema.AnyOf)
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
        foreach (var item in schema.OneOf)
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
        foreach (var item in schema.AllOf)
        {
            children.AddRange(FromSchema(
                schema: item,
                settings: settings,
                parent: context,
                hint: Models.Hint.AllOf,
                index: i++,
                depth: depth + 1));
        }
        
        context.Children = children
            .Where(x => x.Depth == depth + 1)
            .ToList();
        
        return [context, ..children];
    }
    
    public void ComputeData(int level = 0, int maxDepth = 20)
    {
        // Prevent infinite recursion for circular references
        if (level > maxDepth)
        {
            return;
        }
        
        ResolvedReference?.ComputeData(level + 1, maxDepth: maxDepth);
        foreach (var child in Children)
        {
            child.ComputeData(level + 1, maxDepth: maxDepth);
        }
        
        TypeData = IsReference
            ? ResolvedReference?.TypeData
            : Models.TypeData.FromSchemaContext(this);
        if (IsReference && ResolvedReference != null && TypeData.HasValue)
        {
            TypeData = TypeData.Value with
            {
                CSharpType = global::OpenApiGenerator.Core.Models.TypeData.GetCSharpType(ResolvedReference, this),
            };
        }
        if (IsProperty || Hint is Models.Hint.Parameter)
        {
            PropertyData = Models.PropertyData.FromSchemaContext(this);
        }
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
    
    public IReadOnlyCollection<SchemaContext> WithAllChildren(int level = 0, int maxDepth = 20)
    {
        // Prevent infinite recursion for circular references
        if (level > maxDepth)
        {
            return [];
        }
        
        if (IsReference)
        {
            return [this, ..ResolvedReference!.WithAllChildren(level + 1, maxDepth: maxDepth)];
        }
        
        var result = new List<SchemaContext> { this };
        foreach (var child in Children)
        {
            result.AddRange(child.WithAllChildren(level + 1, maxDepth: maxDepth));
        }
        
        return result;
    }
    
    public void ComputeTags(HashSet<string>? parentTags = null, int level = 0, int maxDepth = 20)
    {
        // Prevent infinite recursion for circular references
        if (level > maxDepth)
        {
            return;
        }
        
        foreach (var tag in Operation?.Tags ?? [])
        {
            Tags.Add(tag.Name);
        }
        foreach (var tag in parentTags ?? [])
        {
            Tags.Add(tag);
        }
        
        foreach (var child in Children)
        {
            child.ComputeTags(Tags, level + 1, maxDepth: maxDepth);
        }
        ResolvedReference?.ComputeTags(Tags, level + 1, maxDepth: maxDepth);
    }
}