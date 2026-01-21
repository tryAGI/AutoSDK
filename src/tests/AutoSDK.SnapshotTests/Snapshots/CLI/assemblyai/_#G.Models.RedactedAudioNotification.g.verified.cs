//HintName: G.Models.RedactedAudioNotification.g.cs
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
        /// Example: {"redacted_audio_url":"https://s3.us-west-2.amazonaws.com/api.assembly.ai.usw2/redacted-audio/785efd9e-0e20-45e1-967b-3db17770ed9f.wav?AWSAccessKeyId=ASIAVASQFLPGLUP5JD7Y\u0026Signature=z1r2MOA46esiiAmk%2FreBkL8rl6g%3D\u0026x-amz-security-token=IQoJb3JpZ2luX2VjEPv%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCXVzLXdlc3QtMiJHMEUCIHxKoUJdd5P%2Fdy4WlfvRNppQtauTy7OuAb5azR2OIoYSAiEA8iPx4xAx0pbZztT4e7fGnzPS4phvNCnYKflIijUoxDsq%2BwMIMxAEGgwzNDQ4MzkyNDg4NDQiDJxsCgo0cDg789FV0CrYAwPK3CHbRHoNPFiQ%2FO6EdHZ4OSFRcS%2FDvDyHQRNnYNSwG4JB2mUMWEVw808JWTya%2But4wEcmPiUCVJMTvh70cxhILAxP84CBTuWGM%2Fszbj4tn1thjVsqovf9YZmP17OCFa77Bc9%2F9RwtRaABEqJ2eb6%2Bsir7w0MMzhe1z%2F%2B1PUKxicJAZasBv3Ova%2BTY2eNkPZHQ4Njie4X5sh05b%2BrKnz58E7GTQ1sHZQDYHZecwb5fP0B3LR0vuqNtK%2BdpMAxw5H7BinQ4rdccLmsLLMQeVn8jdRDZNEvsdmoeQL0y0qD%2BUcyGMJoAjMT4FnXhBhVxc3bgkVUbHlZMn48FNCYcmzM8UB9wGmSnr6iQoqEaFElfQVbvAzsW7lnlfLROZxMvGXyliobPYPSaYZlVYgHcIxeWuOAXRtEtmL2jbaX4ghCVgJBVO3BBzTgub2jB0KPU6lYZLLM4kf%2B8hKX8iyxSRc6ZVEefTcyruoDppjB028pA9q75hLH1CZwhfLoM%2F3z5f0aFCl05zQnaa10nbcKj0hERELf4FXqS8yWbSutlRcd7Rr9o8jN31QGUscpsuIvl%2FpyJcZmItX8nO%2FF0s1QjrIi11DLYD9YoOh7eVkN8eKKn5w4cHldVI2sw4NCPqgY6pQE%2BM9va2ad1%2BNrXeQ9t8K41lojTN0BFmM8ERD5fF77xcTlW8VdV%2FiJeLLHDvnYYWVKcga9hSROlmsqvMyn3Tmhz7KQbIepSAOKhcHM%2FyUaLfErvCtjXGwo8nsKForL7SKiGkaRCBmwfQtkSVP6m4tGT50YdGxakh54f8uyC55SbkElknRbpl5haiZ%2F82UddFBkdPcM3t0s7vwbEy%2BbilYyetOr6htc%3D\u0026Expires=1698966551","status":"redacted_audio_ready"}
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
        public static implicit operator RedactedAudioNotification(global::G.RedactedAudioResponse value) => new RedactedAudioNotification((global::G.RedactedAudioResponse?)value);

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
        public override string? ToString() =>
            Response?.ToString() 
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

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
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
