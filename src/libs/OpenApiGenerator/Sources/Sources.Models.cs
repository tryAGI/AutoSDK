using H.Generators.Extensions;
using OpenApiGenerator.Models;

namespace OpenApiGenerator;

internal static partial class Sources
{
    public static string GenerateModel(
        Model model,
        CancellationToken cancellationToken = default)
    {
        return model.Style switch
        {
            ModelStyle.Class => GenerateClassModel(model, cancellationToken),
            _ => throw new NotSupportedException($"Model style {model.Style} is not supported."),
        };
    }
    
    public static string GenerateClassModel(
        Model model,
        CancellationToken cancellationToken = default)
    {
        return $@"
#nullable enable

namespace {model.Namespace}
{{
    {model.Summary.ToXmlDocumentationSummary(level: 4)}
    public sealed class {model.Name}
    {{
{model.Properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        [global::System.Text.Json.Serialization.JsonPropertyName(""{property.Id}"")]
        public{(property.IsRequired ? " required" : "")} {property.Type} {property.Name} {{ get; set; }}{(property.IsRequired || property.DefaultValue == null ? string.Empty : $" = {property.DefaultValue};")}
").Inject()}

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties {{ get; set; }} = new global::System.Collections.Generic.Dictionary<string, object>();
    }}
}}";
    }
}