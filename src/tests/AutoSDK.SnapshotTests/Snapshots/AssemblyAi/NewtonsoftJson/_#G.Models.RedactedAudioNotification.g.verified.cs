//HintName: G.Models.RedactedAudioNotification.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The notification when the redacted audio is ready.
    /// </summary>
    public readonly partial struct RedactedAudioNotification : global::System.IEquatable<RedactedAudioNotification>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RedactedAudioResponse? Response { get; init; }
#else
        public global::G.RedactedAudioResponse? Response { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Response))]
#endif
        public bool IsResponse => Response != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RedactedAudioNotification(global::G.RedactedAudioResponse value) => new RedactedAudioNotification(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RedactedAudioResponse?(RedactedAudioNotification @this) => @this.Response;

        /// <summary>
        /// 
        /// </summary>
        public RedactedAudioNotification(global::G.RedactedAudioResponse? value)
        {
            Response = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Response as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RedactedAudioResponse?, TResult>? response = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse && response != null)
            {
                return response(Response!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RedactedAudioResponse?>? response = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponse)
            {
                response?.Invoke(Response!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Response,
                typeof(global::G.RedactedAudioResponse),
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
        public bool Equals(RedactedAudioNotification other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RedactedAudioResponse?>.Default.Equals(Response, other.Response) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RedactedAudioNotification obj1, RedactedAudioNotification obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RedactedAudioNotification>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RedactedAudioNotification obj1, RedactedAudioNotification obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RedactedAudioNotification o && Equals(o);
        }
    }
}
