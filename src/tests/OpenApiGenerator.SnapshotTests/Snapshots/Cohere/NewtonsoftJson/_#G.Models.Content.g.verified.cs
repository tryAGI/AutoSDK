//HintName: G.Models.Content.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A Content block which contains information about the content type and the content itself.
    /// </summary>
    public readonly partial struct Content : global::System.IEquatable<Content>
    {
        /// <summary>
        /// Text content of the message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextContent? Text { get; init; }
#else
        public global::G.TextContent? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Content(global::G.TextContent value) => new Content(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextContent?(Content @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Content(global::G.TextContent? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.TextContent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextContent?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Content obj1, Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Content obj1, Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Content o && Equals(o);
        }
    }
}
