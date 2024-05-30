using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateAnyOf(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        var (subType, count, _) = anyOfData;
        var types = $"<{string.Join(", ", Enumerable.Range(1, count).Select(x => $"T{x}"))}>";
        var validation = subType switch
        {
            "AnyOf" => string.Join(" || ", Enumerable.Range(1, count).Select(x => $"IsValue{x}")),
            "OneOf" => string.Join(" || ", Enumerable.Range(1, count).Select(x =>
                string.Join(" && ", Enumerable.Range(1, count).Select(y => $"{(y == x ? "!" : "")}IsValue{y}")))),
            "AllOf" => string.Join(" && ", Enumerable.Range(1, count).Select(x => $"IsValue{x}")),
            _ => throw new NotImplementedException(),
        };
        var constructorWithAllValues = count > 1 ? $@"
        public {subType}(
{Enumerable.Range(1, count).Select(x => $@"
            T{x}? value{x},
").Inject().TrimEnd(',', '\n')}
            )
        {{
{Enumerable.Range(1, count).Select(x => $@"
            Value{x} = value{x};
").Inject()}
        }}" : " ";
        
        return $@"using System.Linq;

#nullable enable

namespace System
{{
    public readonly struct {subType}{types} : global::System.IEquatable<{subType}{types}>
    {{
{Enumerable.Range(1, count).Select(x => $@"
#if NET6_0_OR_GREATER
        public T{x}? Value{x} {{ get; init; }}
#else
        public T{x}? Value{x} {{ get; }}
#endif

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value{x}))]
#endif
        public bool IsValue{x} => Value{x} != null;

        public static implicit operator {subType}{types}(T{x} value) => new {subType}{types}(value);

        public static implicit operator T{x}?({subType}{types} @this) => @this.Value{x};

        public {subType}(T{x}? value)
        {{
            Value{x} = value;
        }}
").Inject()}
{constructorWithAllValues}

        public bool Validate()
        {{
            return {validation};
        }}

        public override int GetHashCode()
        {{
            var fields = new object?[]
            {{
{Enumerable.Range(1, count).Select(x => $@"
                Value{x},
                typeof(T{x}),
").Inject()}
            }};
            
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
    
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
    
            return fields.Aggregate(offset, HashCodeAggregator);
        }}

        public bool Equals({subType}{types} other)
        {{
            return
{Enumerable.Range(1, count).Select(x => $@"
                global::System.Collections.Generic.EqualityComparer<T{x}?>.Default.Equals(Value{x}, other.Value{x}) &&
").Inject().TrimEnd('&', '\n')}
                ;
        }}

        public static bool operator ==({subType}{types} obj1, {subType}{types} obj2)
        {{
            return global::System.Collections.Generic.EqualityComparer<{subType}{types}>.Default.Equals(obj1, obj2);
        }}

        public static bool operator !=({subType}{types} obj1, {subType}{types} obj2)
        {{
            return !(obj1 == obj2);
        }}

        public override bool Equals(object? obj)
        {{
            return obj is {subType}{types} o && Equals(o);
        }}
    }}
}}
".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}