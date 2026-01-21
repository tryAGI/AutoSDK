using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateAnyOf(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        var types = $"<{string.Join(", ", Enumerable.Range(1, anyOfData.Count).Select(x => $"T{x}"))}>";
        var classNameWithoutTypes = !anyOfData.IsNamed
            ? $"{anyOfData.SubType}"
            : anyOfData.Name;
        var className = !anyOfData.IsNamed
            ? $"{anyOfData.SubType}{types}"
            : anyOfData.Name;
        var validation = anyOfData.SubType switch
        {
            "AnyOf" => string.Join(" || ", anyOfData.Properties.Select(x => $"Is{x.Name}")),
            "OneOf" => string.Join(" || ", anyOfData.Properties.Select((x, xi) =>
                string.Join(" && ", anyOfData.Properties.Select((y, yi) => $"{(yi == xi ? "" : "!")}Is{y.Name}")))),
            "AllOf" => string.Join(" && ", anyOfData.Properties.Select(x => $"Is{x.Name}")),
            _ => throw new NotImplementedException(),
        };
        var constructorWithAllValues =
            anyOfData.Count > 1 ||
            (anyOfData.IsNamed &&
            anyOfData.DiscriminatorType != null &&
            anyOfData.DiscriminatorPropertyName != null &&
            anyOfData.Properties.All(x => !string.IsNullOrWhiteSpace(x.DiscriminatorValue))) ? $@"
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {classNameWithoutTypes}(
{(!anyOfData.IsNamed ||
  anyOfData.DiscriminatorType == null ||
  anyOfData.DiscriminatorPropertyName == null ||
  anyOfData.Properties.Any(x => string.IsNullOrWhiteSpace(x.DiscriminatorValue)) ? " " : $@" 
            {anyOfData.DiscriminatorType.Value.CSharpTypeWithoutNullability}{anyOfData.DiscriminatorPropertyName}? {anyOfData.DiscriminatorPropertyName.ToParameterName()},
 ")}
{anyOfData.Properties.Select(x => $@" 
            {x.Type.CSharpTypeWithNullability} {x.ParameterName},
").Inject().TrimEnd(',', '\n')}
            )
        {{
{(!anyOfData.IsNamed ||
  anyOfData.DiscriminatorType == null ||
  anyOfData.DiscriminatorPropertyName == null ||
  anyOfData.Properties.Any(x => string.IsNullOrWhiteSpace(x.DiscriminatorValue)) ? " " : $@" 
            {anyOfData.DiscriminatorPropertyName} = {anyOfData.DiscriminatorPropertyName.ToParameterName()};
")}
{anyOfData.Properties.Select(x => $@" 
            {x.Name} = {x.ParameterName};
").Inject()}
        }}" : " ";
        var objectProperty =
            anyOfData.Properties.Any(x => x.ParameterName == "object") ||
            anyOfData.DiscriminatorPropertyName == "Object"
                ? "Object1"
                : "Object";
        
        return $@"{(anyOfData.IsNamed ? @"#pragma warning disable CS0618 // Type or member is obsolete
" : "")}
#nullable enable

namespace {anyOfData.Namespace}
{{
    {anyOfData.Summary.ToXmlDocumentationSummary(level: 4)}
    public readonly partial struct {className} : global::System.IEquatable<{className}>
    {{
{(!anyOfData.IsNamed ||
  anyOfData.DiscriminatorType == null ||
  anyOfData.DiscriminatorPropertyName == null ||
  anyOfData.Properties.Any(x => string.IsNullOrWhiteSpace(x.DiscriminatorValue)) ? " " : $@" 
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {anyOfData.DiscriminatorType.Value.CSharpTypeWithoutNullability}{anyOfData.DiscriminatorPropertyName}? {anyOfData.DiscriminatorPropertyName} {{ get; }}
")}
{anyOfData.Properties.Select(x => $@"
        {x.Summary.ToXmlDocumentationSummary(level: 8)}
#if NET6_0_OR_GREATER
        public {x.Type.CSharpTypeWithNullability} {x.Name} {{ get; init; }}
#else
        public {x.Type.CSharpTypeWithNullability} {x.Name} {{ get; }}
#endif

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof({x.Name}))]
#endif
        public bool Is{x.Name} => {x.Name} != null;
").Inject()}
{anyOfData.Properties
    .GroupBy(x => x.Type.CSharpTypeWithoutNullability) // Deduplicate by type
    .Select(g => g.First()) // Take first property of each type
    .Where(x =>
        className != x.Type.CSharpTypeWithoutNullability &&
        !x.Type.CSharpTypeWithoutNullability.StartsWith("global::System.Collections.Generic.IList", StringComparison.Ordinal) &&
        x.Type.CSharpTypeWithoutNullability != "object")
    .Select(x => $@"
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static implicit operator {className}({x.Type.CSharpTypeWithoutNullability} value) => new {className}(({x.Type.CSharpTypeWithNullability})value);

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static implicit operator {x.Type.CSharpTypeWithNullability}({className} @this) => @this.{x.Name};

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {classNameWithoutTypes}({x.Type.CSharpTypeWithNullability} value)
        {{
            {x.Name} = value;
        }}
").Inject()}
{constructorWithAllValues}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public object? {objectProperty} =>
{anyOfData.Properties.Reverse().Select(x => $@" 
            {x.Name} as object ??
").Inject().TrimEnd('?', '\n')}
            ;

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public override string? ToString() =>
{anyOfData.Properties.Select(x => $@" 
            {x.Name}{(x.Type.IsEnum ? "?.ToValueString()" : "?.ToString()")} ??
").Inject().TrimEnd('?', '\n')}
            ;

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public bool Validate()
        {{
            return {validation};
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public TResult? Match<TResult>(
{anyOfData.Properties.Select(x => $@" 
            global::System.Func<{x.Type.CSharpType}, TResult>? {x.ParameterName} = null,
").Inject()}
            bool validate = true)
        {{
            if (validate)
            {{
                Validate();
            }}

{anyOfData.Properties.Select((x, i) => $@"
            {(i > 0 ? "else " : "")}if (Is{x.Name} && {x.ParameterName} != null)
            {{
                return {x.ParameterName}({x.Name}!);
            }}").Inject()}

            return default(TResult);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public void Match(
{anyOfData.Properties.Select(x => $@" 
            global::System.Action<{x.Type.CSharpType}>? {x.ParameterName} = null,
").Inject()}
            bool validate = true)
        {{
            if (validate)
            {{
                Validate();
            }}

{anyOfData.Properties.Select((x, i) => $@"
            {(i > 0 ? "else " : "")}if (Is{x.Name})
            {{
                {x.ParameterName}?.Invoke({x.Name}!);
            }}").Inject()}
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public override int GetHashCode()
        {{
            var fields = new object?[]
            {{
{anyOfData.Properties.Select(x => $@" 
                {x.Name},
                typeof({x.Type.CSharpTypeWithoutNullability}),
").Inject()}
            }};
            
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
    
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public bool Equals({className} other)
        {{
            return
{anyOfData.Properties.Select(x => $@" 
                global::System.Collections.Generic.EqualityComparer<{x.Type.CSharpTypeWithNullability}>.Default.Equals({x.Name}, other.{x.Name}) &&
").Inject().TrimEnd('&', '\n')}
                ;
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static bool operator ==({className} obj1, {className} obj2)
        {{
            return global::System.Collections.Generic.EqualityComparer<{className}>.Default.Equals(obj1, obj2);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static bool operator !=({className} obj1, {className} obj2)
        {{
            return !(obj1 == obj2);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public override bool Equals(object? obj)
        {{
            return obj is {className} o && Equals(o);
        }}
    }}
}}
".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}