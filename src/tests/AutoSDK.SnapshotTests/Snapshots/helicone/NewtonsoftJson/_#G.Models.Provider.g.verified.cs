//HintName: G.Models.Provider.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Provider : global::System.IEquatable<Provider>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ProviderName? Name { get; init; }
#else
        public global::G.ProviderName? Name { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Name))]
#endif
        public bool IsName => Name != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ModelProviderName? ModelName { get; init; }
#else
        public global::G.ModelProviderName? ModelName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelName))]
#endif
        public bool IsModelName => ModelName != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ProviderEnum? Enum { get; init; }
#else
        public global::G.ProviderEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Provider(global::G.ProviderName value) => new Provider((global::G.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderName?(Provider @this) => @this.Name;

        /// <summary>
        /// 
        /// </summary>
        public Provider(global::G.ProviderName? value)
        {
            Name = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Provider(global::G.ModelProviderName value) => new Provider((global::G.ModelProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ModelProviderName?(Provider @this) => @this.ModelName;

        /// <summary>
        /// 
        /// </summary>
        public Provider(global::G.ModelProviderName? value)
        {
            ModelName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Provider(global::G.ProviderEnum value) => new Provider((global::G.ProviderEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ProviderEnum?(Provider @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public Provider(global::G.ProviderEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Provider(
            global::G.ProviderName? name,
            global::G.ModelProviderName? modelName,
            global::G.ProviderEnum? @enum
            )
        {
            Name = name;
            ModelName = modelName;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            ModelName as object ??
            Name as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Name?.ToValueString() ??
            ModelName?.ToValueString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsName || IsModelName || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ProviderName?, TResult>? name = null,
            global::System.Func<global::G.ModelProviderName?, TResult>? modelName = null,
            global::System.Func<global::G.ProviderEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsName && name != null)
            {
                return name(Name!);
            }
            else if (IsModelName && modelName != null)
            {
                return modelName(ModelName!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ProviderName?>? name = null,
            global::System.Action<global::G.ModelProviderName?>? modelName = null,
            global::System.Action<global::G.ProviderEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsName)
            {
                name?.Invoke(Name!);
            }
            else if (IsModelName)
            {
                modelName?.Invoke(ModelName!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Name,
                typeof(global::G.ProviderName),
                ModelName,
                typeof(global::G.ModelProviderName),
                Enum,
                typeof(global::G.ProviderEnum),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Provider other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderName?>.Default.Equals(Name, other.Name) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ModelProviderName?>.Default.Equals(ModelName, other.ModelName) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ProviderEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Provider obj1, Provider obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Provider>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Provider obj1, Provider obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Provider o && Equals(o);
        }
    }
}
