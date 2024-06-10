using System.Collections.Immutable;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateAnyOf(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        var (subType, count, _, _, @namespace, className, fixedTypes) = anyOfData;
        var types = $"<{string.Join(", ", Enumerable.Range(1, count).Select(x => $"T{x}"))}>";
        var validation = subType switch
        {
            "AnyOf" => string.Join(" || ", Enumerable.Range(1, count).Select(x => $"IsValue{x}")),
            "OneOf" => string.Join(" || ", Enumerable.Range(1, count).Select(x =>
                string.Join(" && ", Enumerable.Range(1, count).Select(y => $"{(y == x ? "!" : "")}IsValue{y}")))),
            "AllOf" => string.Join(" && ", Enumerable.Range(1, count).Select(x => $"IsValue{x}")),
            _ => throw new NotImplementedException(),
        };
        var classNameWithoutTypes = string.IsNullOrWhiteSpace(className)
            ? $"{subType}"
            : className;
        className = string.IsNullOrWhiteSpace(className)
            ? $"{subType}{types}"
            : className;
        var allTypes = fixedTypes.IsEmpty
            ? Enumerable
                .Range(1, count)
                .Select(i => PropertyData.Default with
                {
                    Name = $"Value{i}",
                    Type = TypeData.Default with
                    {
                        CSharpType = $"T{i}",
                    },
                })
                .ToImmutableArray()
            : fixedTypes.Select((type, i) => PropertyData.Default with
            {
                Name = $"Value{i + 1}",
                Type = type,
            }).ToImmutableArray();
        var constructorWithAllValues = count > 1 ? $@"
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {classNameWithoutTypes}(
{allTypes.Select(x => $@" 
            {x.Type.CSharpTypeWithNullability} {x.Name.ToParameterName()},
").Inject().TrimEnd(',', '\n')}
            )
        {{
{allTypes.Select(x => $@" 
            {x.Name} = {x.Name.ToParameterName()};
").Inject()}
        }}" : " ";
        
        return $@"using System.Linq;

#nullable enable

namespace {@namespace}
{{
    {string.Empty.ToXmlDocumentationSummary(level: 4)}
    public readonly struct {className} : global::System.IEquatable<{className}>
    {{
{allTypes.Select(x => $@"
        {x.Summary.ToXmlDocumentationSummary(level: 8)}
#if NET6_0_OR_GREATER
        public {x.Type.CSharpTypeWithNullability} {x.Name} {{ get; init; }}
#else
        public {x.Type.CSharpTypeWithNullability} {x.Name} {{ get; }}
#endif

        {x.Summary.ToXmlDocumentationSummary(level: 8)}
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof({x.Name}))]
#endif
        public bool Is{x.Name} => {x.Name} != null;
{(className != x.Type.CSharpTypeWithoutNullability ? $@"
        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static implicit operator {className}({x.Type.CSharpTypeWithoutNullability} value) => new {className}(value);

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public static implicit operator {x.Type.CSharpTypeWithNullability}({className} @this) => @this.{x.Name};
 " : " ")}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public {classNameWithoutTypes}({x.Type.CSharpTypeWithNullability} value)
        {{
            {x.Name} = value;
        }}
").Inject()}
{constructorWithAllValues}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public object? Object =>
{allTypes.Reverse().Select(x => $@" 
            {x.Name} as object ??
").Inject().TrimEnd('?', '\n')}
            ;

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public bool Validate()
        {{
            return {validation};
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public override int GetHashCode()
        {{
            var fields = new object?[]
            {{
{allTypes.Select(x => $@" 
                {x.Name},
                typeof({x.Type.CSharpTypeWithoutNullability}),
").Inject()}
            }};
            
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
    
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
    
            return fields.Aggregate(offset, HashCodeAggregator);
        }}

        {string.Empty.ToXmlDocumentationSummary(level: 8)}
        public bool Equals({className} other)
        {{
            return
{allTypes.Select(x => $@" 
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