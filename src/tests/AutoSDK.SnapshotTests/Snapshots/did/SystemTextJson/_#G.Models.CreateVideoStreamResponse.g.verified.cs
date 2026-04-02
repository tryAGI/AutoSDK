//HintName: G.Models.CreateVideoStreamResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateVideoStreamResponse : global::System.IEquatable<CreateVideoStreamResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateVideoStreamResponseVariant1? CreateVideoStreamResponseVariant1 { get; init; }
#else
        public global::G.CreateVideoStreamResponseVariant1? CreateVideoStreamResponseVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateVideoStreamResponseVariant1))]
#endif
        public bool IsCreateVideoStreamResponseVariant1 => CreateVideoStreamResponseVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateVideoStreamResponseVariant2? CreateVideoStreamResponseVariant2 { get; init; }
#else
        public global::G.CreateVideoStreamResponseVariant2? CreateVideoStreamResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateVideoStreamResponseVariant2))]
#endif
        public bool IsCreateVideoStreamResponseVariant2 => CreateVideoStreamResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateVideoStreamResponse(global::G.CreateVideoStreamResponseVariant1 value) => new CreateVideoStreamResponse((global::G.CreateVideoStreamResponseVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateVideoStreamResponseVariant1?(CreateVideoStreamResponse @this) => @this.CreateVideoStreamResponseVariant1;

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoStreamResponse(global::G.CreateVideoStreamResponseVariant1? value)
        {
            CreateVideoStreamResponseVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateVideoStreamResponse(global::G.CreateVideoStreamResponseVariant2 value) => new CreateVideoStreamResponse((global::G.CreateVideoStreamResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateVideoStreamResponseVariant2?(CreateVideoStreamResponse @this) => @this.CreateVideoStreamResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoStreamResponse(global::G.CreateVideoStreamResponseVariant2? value)
        {
            CreateVideoStreamResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateVideoStreamResponse(
            global::G.CreateVideoStreamResponseVariant1? createVideoStreamResponseVariant1,
            global::G.CreateVideoStreamResponseVariant2? createVideoStreamResponseVariant2
            )
        {
            CreateVideoStreamResponseVariant1 = createVideoStreamResponseVariant1;
            CreateVideoStreamResponseVariant2 = createVideoStreamResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateVideoStreamResponseVariant2 as object ??
            CreateVideoStreamResponseVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateVideoStreamResponseVariant1?.ToString() ??
            CreateVideoStreamResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateVideoStreamResponseVariant1 && IsCreateVideoStreamResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateVideoStreamResponseVariant1?, TResult>? createVideoStreamResponseVariant1 = null,
            global::System.Func<global::G.CreateVideoStreamResponseVariant2?, TResult>? createVideoStreamResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateVideoStreamResponseVariant1 && createVideoStreamResponseVariant1 != null)
            {
                return createVideoStreamResponseVariant1(CreateVideoStreamResponseVariant1!);
            }
            else if (IsCreateVideoStreamResponseVariant2 && createVideoStreamResponseVariant2 != null)
            {
                return createVideoStreamResponseVariant2(CreateVideoStreamResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateVideoStreamResponseVariant1?>? createVideoStreamResponseVariant1 = null,
            global::System.Action<global::G.CreateVideoStreamResponseVariant2?>? createVideoStreamResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateVideoStreamResponseVariant1)
            {
                createVideoStreamResponseVariant1?.Invoke(CreateVideoStreamResponseVariant1!);
            }
            else if (IsCreateVideoStreamResponseVariant2)
            {
                createVideoStreamResponseVariant2?.Invoke(CreateVideoStreamResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateVideoStreamResponseVariant1,
                typeof(global::G.CreateVideoStreamResponseVariant1),
                CreateVideoStreamResponseVariant2,
                typeof(global::G.CreateVideoStreamResponseVariant2),
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
        public bool Equals(CreateVideoStreamResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateVideoStreamResponseVariant1?>.Default.Equals(CreateVideoStreamResponseVariant1, other.CreateVideoStreamResponseVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateVideoStreamResponseVariant2?>.Default.Equals(CreateVideoStreamResponseVariant2, other.CreateVideoStreamResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateVideoStreamResponse obj1, CreateVideoStreamResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateVideoStreamResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateVideoStreamResponse obj1, CreateVideoStreamResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateVideoStreamResponse o && Equals(o);
        }
    }
}
