//HintName: G.Models.GenerateStreamText.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GenerateStreamText : global::System.IEquatable<GenerateStreamText>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateStreamEvent? Event { get; init; }
#else
        public global::G.GenerateStreamEvent? Event { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event))]
#endif
        public bool IsEvent => Event != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GenerateStreamTextYai5v6? Yai5v6 { get; init; }
#else
        public global::G.GenerateStreamTextYai5v6? Yai5v6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Yai5v6))]
#endif
        public bool IsYai5v6 => Yai5v6 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamText(global::G.GenerateStreamEvent value) => new GenerateStreamText((global::G.GenerateStreamEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateStreamEvent?(GenerateStreamText @this) => @this.Event;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamText(global::G.GenerateStreamEvent? value)
        {
            Event = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateStreamText(global::G.GenerateStreamTextYai5v6 value) => new GenerateStreamText((global::G.GenerateStreamTextYai5v6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GenerateStreamTextYai5v6?(GenerateStreamText @this) => @this.Yai5v6;

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamText(global::G.GenerateStreamTextYai5v6? value)
        {
            Yai5v6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GenerateStreamText(
            global::G.GenerateStreamEvent? @event,
            global::G.GenerateStreamTextYai5v6? yai5v6
            )
        {
            Event = @event;
            Yai5v6 = yai5v6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Yai5v6 as object ??
            Event as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Event?.ToString() ??
            Yai5v6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEvent && IsYai5v6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GenerateStreamEvent?, TResult>? @event = null,
            global::System.Func<global::G.GenerateStreamTextYai5v6?, TResult>? yai5v6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent && @event != null)
            {
                return @event(Event!);
            }
            else if (IsYai5v6 && yai5v6 != null)
            {
                return yai5v6(Yai5v6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GenerateStreamEvent?>? @event = null,
            global::System.Action<global::G.GenerateStreamTextYai5v6?>? yai5v6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEvent)
            {
                @event?.Invoke(Event!);
            }
            else if (IsYai5v6)
            {
                yai5v6?.Invoke(Yai5v6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Event,
                typeof(global::G.GenerateStreamEvent),
                Yai5v6,
                typeof(global::G.GenerateStreamTextYai5v6),
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
        public bool Equals(GenerateStreamText other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateStreamEvent?>.Default.Equals(Event, other.Event) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GenerateStreamTextYai5v6?>.Default.Equals(Yai5v6, other.Yai5v6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GenerateStreamText obj1, GenerateStreamText obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateStreamText>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GenerateStreamText obj1, GenerateStreamText obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateStreamText o && Equals(o);
        }
    }
}
