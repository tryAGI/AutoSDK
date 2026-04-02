//HintName: G.Models.CreateModelStatus.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Status creating the model
    /// </summary>
    public readonly partial struct CreateModelStatus : global::System.IEquatable<CreateModelStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? CreateModelStatusVariant1 { get; init; }
#else
        public string? CreateModelStatusVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateModelStatusVariant1))]
#endif
        public bool IsCreateModelStatusVariant1 => CreateModelStatusVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateModelStatusEnum? Enum { get; init; }
#else
        public global::G.CreateModelStatusEnum? Enum { get; }
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
        public static implicit operator CreateModelStatus(string value) => new CreateModelStatus((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(CreateModelStatus @this) => @this.CreateModelStatusVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CreateModelStatus(string? value)
        {
            CreateModelStatusVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateModelStatus(global::G.CreateModelStatusEnum value) => new CreateModelStatus((global::G.CreateModelStatusEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateModelStatusEnum?(CreateModelStatus @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public CreateModelStatus(global::G.CreateModelStatusEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateModelStatus(
            string? createModelStatusVariant1,
            global::G.CreateModelStatusEnum? @enum
            )
        {
            CreateModelStatusVariant1 = createModelStatusVariant1;
            Enum = @enum;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Enum as object ??
            CreateModelStatusVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateModelStatusVariant1?.ToString() ??
            Enum?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateModelStatusVariant1 || IsEnum;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? createModelStatusVariant1 = null,
            global::System.Func<global::G.CreateModelStatusEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateModelStatusVariant1 && createModelStatusVariant1 != null)
            {
                return createModelStatusVariant1(CreateModelStatusVariant1!);
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
            global::System.Action<string?>? createModelStatusVariant1 = null,
            global::System.Action<global::G.CreateModelStatusEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateModelStatusVariant1)
            {
                createModelStatusVariant1?.Invoke(CreateModelStatusVariant1!);
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
                CreateModelStatusVariant1,
                typeof(string),
                Enum,
                typeof(global::G.CreateModelStatusEnum),
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
        public bool Equals(CreateModelStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(CreateModelStatusVariant1, other.CreateModelStatusVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateModelStatusEnum?>.Default.Equals(Enum, other.Enum) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateModelStatus obj1, CreateModelStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateModelStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateModelStatus obj1, CreateModelStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateModelStatus o && Equals(o);
        }
    }
}
