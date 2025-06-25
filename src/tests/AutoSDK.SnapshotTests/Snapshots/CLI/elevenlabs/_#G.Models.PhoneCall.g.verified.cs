//HintName: G.Models.PhoneCall.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoneCall : global::System.IEquatable<PhoneCall>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationHistoryTwilioPhoneCallModel? Twilio { get; init; }
#else
        public global::G.ConversationHistoryTwilioPhoneCallModel? Twilio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Twilio))]
#endif
        public bool IsTwilio => Twilio != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneCall(global::G.ConversationHistoryTwilioPhoneCallModel value) => new PhoneCall((global::G.ConversationHistoryTwilioPhoneCallModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationHistoryTwilioPhoneCallModel?(PhoneCall @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public PhoneCall(global::G.ConversationHistoryTwilioPhoneCallModel? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConversationHistorySIPTrunkingPhoneCallModel? SipTrunking { get; init; }
#else
        public global::G.ConversationHistorySIPTrunkingPhoneCallModel? SipTrunking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipTrunking))]
#endif
        public bool IsSipTrunking => SipTrunking != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneCall(global::G.ConversationHistorySIPTrunkingPhoneCallModel value) => new PhoneCall((global::G.ConversationHistorySIPTrunkingPhoneCallModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationHistorySIPTrunkingPhoneCallModel?(PhoneCall @this) => @this.SipTrunking;

        /// <summary>
        /// 
        /// </summary>
        public PhoneCall(global::G.ConversationHistorySIPTrunkingPhoneCallModel? value)
        {
            SipTrunking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PhoneCall(
            global::G.ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType? type,
            global::G.ConversationHistoryTwilioPhoneCallModel? twilio,
            global::G.ConversationHistorySIPTrunkingPhoneCallModel? sipTrunking
            )
        {
            Type = type;

            Twilio = twilio;
            SipTrunking = sipTrunking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SipTrunking as object ??
            Twilio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Twilio?.ToString() ??
            SipTrunking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTwilio && !IsSipTrunking || !IsTwilio && IsSipTrunking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ConversationHistoryTwilioPhoneCallModel?, TResult>? twilio = null,
            global::System.Func<global::G.ConversationHistorySIPTrunkingPhoneCallModel?, TResult>? sipTrunking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTwilio && twilio != null)
            {
                return twilio(Twilio!);
            }
            else if (IsSipTrunking && sipTrunking != null)
            {
                return sipTrunking(SipTrunking!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ConversationHistoryTwilioPhoneCallModel?>? twilio = null,
            global::System.Action<global::G.ConversationHistorySIPTrunkingPhoneCallModel?>? sipTrunking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsSipTrunking)
            {
                sipTrunking?.Invoke(SipTrunking!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Twilio,
                typeof(global::G.ConversationHistoryTwilioPhoneCallModel),
                SipTrunking,
                typeof(global::G.ConversationHistorySIPTrunkingPhoneCallModel),
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
        public bool Equals(PhoneCall other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationHistoryTwilioPhoneCallModel?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationHistorySIPTrunkingPhoneCallModel?>.Default.Equals(SipTrunking, other.SipTrunking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoneCall obj1, PhoneCall obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneCall>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoneCall obj1, PhoneCall obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneCall o && Equals(o);
        }
    }
}
