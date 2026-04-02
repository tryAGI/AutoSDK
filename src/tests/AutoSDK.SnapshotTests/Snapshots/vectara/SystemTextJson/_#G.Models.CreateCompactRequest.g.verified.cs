//HintName: G.Models.CreateCompactRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Requests compaction of the session history. Can be sent while the session is processing<br/>
    /// (queued as a follow-up) or when idle.
    /// </summary>
    public readonly partial struct CreateCompactRequest : global::System.IEquatable<CreateCompactRequest>
    {
        /// <summary>
        /// Base properties shared by all input request types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateInputRequestBase? InputBase { get; init; }
#else
        public global::G.CreateInputRequestBase? InputBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputBase))]
#endif
        public bool IsInputBase => InputBase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateCompactRequestVariant2? CreateCompactRequestVariant2 { get; init; }
#else
        public global::G.CreateCompactRequestVariant2? CreateCompactRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateCompactRequestVariant2))]
#endif
        public bool IsCreateCompactRequestVariant2 => CreateCompactRequestVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateCompactRequest(global::G.CreateInputRequestBase value) => new CreateCompactRequest((global::G.CreateInputRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateInputRequestBase?(CreateCompactRequest @this) => @this.InputBase;

        /// <summary>
        /// 
        /// </summary>
        public CreateCompactRequest(global::G.CreateInputRequestBase? value)
        {
            InputBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateCompactRequest(global::G.CreateCompactRequestVariant2 value) => new CreateCompactRequest((global::G.CreateCompactRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateCompactRequestVariant2?(CreateCompactRequest @this) => @this.CreateCompactRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateCompactRequest(global::G.CreateCompactRequestVariant2? value)
        {
            CreateCompactRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateCompactRequest(
            global::G.CreateInputRequestBase? inputBase,
            global::G.CreateCompactRequestVariant2? createCompactRequestVariant2
            )
        {
            InputBase = inputBase;
            CreateCompactRequestVariant2 = createCompactRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateCompactRequestVariant2 as object ??
            InputBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputBase?.ToString() ??
            CreateCompactRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputBase && IsCreateCompactRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateInputRequestBase?, TResult>? inputBase = null,
            global::System.Func<global::G.CreateCompactRequestVariant2?, TResult>? createCompactRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputBase && inputBase != null)
            {
                return inputBase(InputBase!);
            }
            else if (IsCreateCompactRequestVariant2 && createCompactRequestVariant2 != null)
            {
                return createCompactRequestVariant2(CreateCompactRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateInputRequestBase?>? inputBase = null,
            global::System.Action<global::G.CreateCompactRequestVariant2?>? createCompactRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputBase)
            {
                inputBase?.Invoke(InputBase!);
            }
            else if (IsCreateCompactRequestVariant2)
            {
                createCompactRequestVariant2?.Invoke(CreateCompactRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputBase,
                typeof(global::G.CreateInputRequestBase),
                CreateCompactRequestVariant2,
                typeof(global::G.CreateCompactRequestVariant2),
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
        public bool Equals(CreateCompactRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateInputRequestBase?>.Default.Equals(InputBase, other.InputBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateCompactRequestVariant2?>.Default.Equals(CreateCompactRequestVariant2, other.CreateCompactRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateCompactRequest obj1, CreateCompactRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateCompactRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateCompactRequest obj1, CreateCompactRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateCompactRequest o && Equals(o);
        }
    }
}
