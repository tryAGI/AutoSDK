//HintName: G.Models.PhoneCallVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoneCallVariant1 : global::System.IEquatable<PhoneCallVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType? Type { get; }

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
        public bool TryPickTwilio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConversationHistoryTwilioPhoneCallModel? value)
        {
            value = Twilio;
            return IsTwilio;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationHistoryTwilioPhoneCallModel PickTwilio() => Twilio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Twilio' but the value was {ToString()}.");

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
        public bool TryPickSipTrunking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.ConversationHistorySIPTrunkingPhoneCallModel? value)
        {
            value = SipTrunking;
            return IsSipTrunking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.ConversationHistorySIPTrunkingPhoneCallModel PickSipTrunking() => SipTrunking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipTrunking' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneCallVariant1(global::G.ConversationHistoryTwilioPhoneCallModel value) => new PhoneCallVariant1((global::G.ConversationHistoryTwilioPhoneCallModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationHistoryTwilioPhoneCallModel?(PhoneCallVariant1 @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public PhoneCallVariant1(global::G.ConversationHistoryTwilioPhoneCallModel? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PhoneCallVariant1 FromTwilio(global::G.ConversationHistoryTwilioPhoneCallModel? value) => new PhoneCallVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneCallVariant1(global::G.ConversationHistorySIPTrunkingPhoneCallModel value) => new PhoneCallVariant1((global::G.ConversationHistorySIPTrunkingPhoneCallModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConversationHistorySIPTrunkingPhoneCallModel?(PhoneCallVariant1 @this) => @this.SipTrunking;

        /// <summary>
        /// 
        /// </summary>
        public PhoneCallVariant1(global::G.ConversationHistorySIPTrunkingPhoneCallModel? value)
        {
            SipTrunking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PhoneCallVariant1 FromSipTrunking(global::G.ConversationHistorySIPTrunkingPhoneCallModel? value) => new PhoneCallVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public PhoneCallVariant1(
            global::G.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType? type,
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
            global::System.Func<global::G.ConversationHistoryTwilioPhoneCallModel, TResult>? twilio = null,
            global::System.Func<global::G.ConversationHistorySIPTrunkingPhoneCallModel, TResult>? sipTrunking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Twilio is { } __value0 && twilio != null)
            {
                return twilio(__value0);
            }
            else if (SipTrunking is { } __value1 && sipTrunking != null)
            {
                return sipTrunking(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ConversationHistoryTwilioPhoneCallModel>? twilio = null,

            global::System.Action<global::G.ConversationHistorySIPTrunkingPhoneCallModel>? sipTrunking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Twilio is { } __value0)
            {
                twilio?.Invoke(__value0);
            }
            else if (SipTrunking is { } __value1)
            {
                sipTrunking?.Invoke(__value1);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.ConversationHistoryTwilioPhoneCallModel>? twilio = null,
            global::System.Action<global::G.ConversationHistorySIPTrunkingPhoneCallModel>? sipTrunking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Twilio is { } __value0)
            {
                twilio?.Invoke(__value0);
            }
            else if (SipTrunking is { } __value1)
            {
                sipTrunking?.Invoke(__value1);
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
        public bool Equals(PhoneCallVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationHistoryTwilioPhoneCallModel?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConversationHistorySIPTrunkingPhoneCallModel?>.Default.Equals(SipTrunking, other.SipTrunking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoneCallVariant1 obj1, PhoneCallVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneCallVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoneCallVariant1 obj1, PhoneCallVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneCallVariant1 o && Equals(o);
        }
    }
}
