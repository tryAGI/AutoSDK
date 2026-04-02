//HintName: G.Models.CreateInputMessageRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A user input message with text or other content.
    /// </summary>
    public readonly partial struct CreateInputMessageRequest : global::System.IEquatable<CreateInputMessageRequest>
    {
        /// <summary>
        /// Base properties shared by all input request types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateInputRequestBase? Base { get; init; }
#else
        public global::G.CreateInputRequestBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateInputMessageRequestVariant2? CreateInputMessageRequestVariant2 { get; init; }
#else
        public global::G.CreateInputMessageRequestVariant2? CreateInputMessageRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateInputMessageRequestVariant2))]
#endif
        public bool IsCreateInputMessageRequestVariant2 => CreateInputMessageRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInputMessageRequest(global::G.CreateInputRequestBase value) => new CreateInputMessageRequest((global::G.CreateInputRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateInputRequestBase?(CreateInputMessageRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CreateInputMessageRequest(global::G.CreateInputRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateInputMessageRequest(global::G.CreateInputMessageRequestVariant2 value) => new CreateInputMessageRequest((global::G.CreateInputMessageRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateInputMessageRequestVariant2?(CreateInputMessageRequest @this) => @this.CreateInputMessageRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateInputMessageRequest(global::G.CreateInputMessageRequestVariant2? value)
        {
            CreateInputMessageRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateInputMessageRequest(
            global::G.CreateInputRequestBase? @base,
            global::G.CreateInputMessageRequestVariant2? createInputMessageRequestVariant2
            )
        {
            Base = @base;
            CreateInputMessageRequestVariant2 = createInputMessageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateInputMessageRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateInputMessageRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateInputMessageRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateInputRequestBase?, TResult>? @base = null,
            global::System.Func<global::G.CreateInputMessageRequestVariant2?, TResult>? createInputMessageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsCreateInputMessageRequestVariant2 && createInputMessageRequestVariant2 != null)
            {
                return createInputMessageRequestVariant2(CreateInputMessageRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateInputRequestBase?>? @base = null,
            global::System.Action<global::G.CreateInputMessageRequestVariant2?>? createInputMessageRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsCreateInputMessageRequestVariant2)
            {
                createInputMessageRequestVariant2?.Invoke(CreateInputMessageRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.CreateInputRequestBase),
                CreateInputMessageRequestVariant2,
                typeof(global::G.CreateInputMessageRequestVariant2),
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
        public bool Equals(CreateInputMessageRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateInputRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateInputMessageRequestVariant2?>.Default.Equals(CreateInputMessageRequestVariant2, other.CreateInputMessageRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateInputMessageRequest obj1, CreateInputMessageRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateInputMessageRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateInputMessageRequest obj1, CreateInputMessageRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateInputMessageRequest o && Equals(o);
        }
    }
}
