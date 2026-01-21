//HintName: G.Models.PhoneNumbersItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoneNumbersItem : global::System.IEquatable<PhoneNumbersItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetAgentResponseModelPhoneNumberDiscriminatorProvider? Provider { get; }

        /// <summary>
        /// Example: {"phone_number_id":"X3Pbu5gP6NNKBscdCdwB"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetPhoneNumberTwilioResponseModel? Twilio { get; init; }
#else
        public global::G.GetPhoneNumberTwilioResponseModel? Twilio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Twilio))]
#endif
        public bool IsTwilio => Twilio != null;

        /// <summary>
        /// Example: {"phone_number_id":"X3Pbu5gP6NNKBscdCdwB"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetPhoneNumberSIPTrunkResponseModel? SipTrunk { get; init; }
#else
        public global::G.GetPhoneNumberSIPTrunkResponseModel? SipTrunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipTrunk))]
#endif
        public bool IsSipTrunk => SipTrunk != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumbersItem(global::G.GetPhoneNumberTwilioResponseModel value) => new PhoneNumbersItem((global::G.GetPhoneNumberTwilioResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetPhoneNumberTwilioResponseModel?(PhoneNumbersItem @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumbersItem(global::G.GetPhoneNumberTwilioResponseModel? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumbersItem(global::G.GetPhoneNumberSIPTrunkResponseModel value) => new PhoneNumbersItem((global::G.GetPhoneNumberSIPTrunkResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetPhoneNumberSIPTrunkResponseModel?(PhoneNumbersItem @this) => @this.SipTrunk;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumbersItem(global::G.GetPhoneNumberSIPTrunkResponseModel? value)
        {
            SipTrunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumbersItem(
            global::G.GetAgentResponseModelPhoneNumberDiscriminatorProvider? provider,
            global::G.GetPhoneNumberTwilioResponseModel? twilio,
            global::G.GetPhoneNumberSIPTrunkResponseModel? sipTrunk
            )
        {
            Provider = provider;

            Twilio = twilio;
            SipTrunk = sipTrunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SipTrunk as object ??
            Twilio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Twilio?.ToString() ??
            SipTrunk?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTwilio && !IsSipTrunk || !IsTwilio && IsSipTrunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GetPhoneNumberTwilioResponseModel?, TResult>? twilio = null,
            global::System.Func<global::G.GetPhoneNumberSIPTrunkResponseModel?, TResult>? sipTrunk = null,
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
            else if (IsSipTrunk && sipTrunk != null)
            {
                return sipTrunk(SipTrunk!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GetPhoneNumberTwilioResponseModel?>? twilio = null,
            global::System.Action<global::G.GetPhoneNumberSIPTrunkResponseModel?>? sipTrunk = null,
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
            else if (IsSipTrunk)
            {
                sipTrunk?.Invoke(SipTrunk!);
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
                typeof(global::G.GetPhoneNumberTwilioResponseModel),
                SipTrunk,
                typeof(global::G.GetPhoneNumberSIPTrunkResponseModel),
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
        public bool Equals(PhoneNumbersItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GetPhoneNumberTwilioResponseModel?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetPhoneNumberSIPTrunkResponseModel?>.Default.Equals(SipTrunk, other.SipTrunk) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoneNumbersItem obj1, PhoneNumbersItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneNumbersItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoneNumbersItem obj1, PhoneNumbersItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneNumbersItem o && Equals(o);
        }
    }
}
