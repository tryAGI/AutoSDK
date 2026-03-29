//HintName: G.Models.PhoneNumberControllerUpdateResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoneNumberControllerUpdateResponse : global::System.IEquatable<PhoneNumberControllerUpdateResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PhoneNumberControllerUpdateResponseDiscriminatorProvider? Provider { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ByoPhoneNumber? ByoPhoneNumber { get; init; }
#else
        public global::G.ByoPhoneNumber? ByoPhoneNumber { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ByoPhoneNumber))]
#endif
        public bool IsByoPhoneNumber => ByoPhoneNumber != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TwilioPhoneNumber? Twilio { get; init; }
#else
        public global::G.TwilioPhoneNumber? Twilio { get; }
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
#if NET6_0_OR_GREATER
        public global::G.VonagePhoneNumber? Vonage { get; init; }
#else
        public global::G.VonagePhoneNumber? Vonage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vonage))]
#endif
        public bool IsVonage => Vonage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VapiPhoneNumber? Vapi { get; init; }
#else
        public global::G.VapiPhoneNumber? Vapi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vapi))]
#endif
        public bool IsVapi => Vapi != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TelnyxPhoneNumber? Telnyx { get; init; }
#else
        public global::G.TelnyxPhoneNumber? Telnyx { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Telnyx))]
#endif
        public bool IsTelnyx => Telnyx != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateResponse(global::G.ByoPhoneNumber value) => new PhoneNumberControllerUpdateResponse((global::G.ByoPhoneNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ByoPhoneNumber?(PhoneNumberControllerUpdateResponse @this) => @this.ByoPhoneNumber;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateResponse(global::G.ByoPhoneNumber? value)
        {
            ByoPhoneNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateResponse(global::G.TwilioPhoneNumber value) => new PhoneNumberControllerUpdateResponse((global::G.TwilioPhoneNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TwilioPhoneNumber?(PhoneNumberControllerUpdateResponse @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateResponse(global::G.TwilioPhoneNumber? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateResponse(global::G.VonagePhoneNumber value) => new PhoneNumberControllerUpdateResponse((global::G.VonagePhoneNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VonagePhoneNumber?(PhoneNumberControllerUpdateResponse @this) => @this.Vonage;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateResponse(global::G.VonagePhoneNumber? value)
        {
            Vonage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateResponse(global::G.VapiPhoneNumber value) => new PhoneNumberControllerUpdateResponse((global::G.VapiPhoneNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VapiPhoneNumber?(PhoneNumberControllerUpdateResponse @this) => @this.Vapi;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateResponse(global::G.VapiPhoneNumber? value)
        {
            Vapi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateResponse(global::G.TelnyxPhoneNumber value) => new PhoneNumberControllerUpdateResponse((global::G.TelnyxPhoneNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TelnyxPhoneNumber?(PhoneNumberControllerUpdateResponse @this) => @this.Telnyx;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateResponse(global::G.TelnyxPhoneNumber? value)
        {
            Telnyx = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateResponse(
            global::G.PhoneNumberControllerUpdateResponseDiscriminatorProvider? provider,
            global::G.ByoPhoneNumber? byoPhoneNumber,
            global::G.TwilioPhoneNumber? twilio,
            global::G.VonagePhoneNumber? vonage,
            global::G.VapiPhoneNumber? vapi,
            global::G.TelnyxPhoneNumber? telnyx
            )
        {
            Provider = provider;

            ByoPhoneNumber = byoPhoneNumber;
            Twilio = twilio;
            Vonage = vonage;
            Vapi = vapi;
            Telnyx = telnyx;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Telnyx as object ??
            Vapi as object ??
            Vonage as object ??
            Twilio as object ??
            ByoPhoneNumber as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ByoPhoneNumber?.ToString() ??
            Twilio?.ToString() ??
            Vonage?.ToString() ??
            Vapi?.ToString() ??
            Telnyx?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsByoPhoneNumber && !IsTwilio && !IsVonage && !IsVapi && !IsTelnyx || !IsByoPhoneNumber && IsTwilio && !IsVonage && !IsVapi && !IsTelnyx || !IsByoPhoneNumber && !IsTwilio && IsVonage && !IsVapi && !IsTelnyx || !IsByoPhoneNumber && !IsTwilio && !IsVonage && IsVapi && !IsTelnyx || !IsByoPhoneNumber && !IsTwilio && !IsVonage && !IsVapi && IsTelnyx;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ByoPhoneNumber?, TResult>? byoPhoneNumber = null,
            global::System.Func<global::G.TwilioPhoneNumber?, TResult>? twilio = null,
            global::System.Func<global::G.VonagePhoneNumber?, TResult>? vonage = null,
            global::System.Func<global::G.VapiPhoneNumber?, TResult>? vapi = null,
            global::System.Func<global::G.TelnyxPhoneNumber?, TResult>? telnyx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsByoPhoneNumber && byoPhoneNumber != null)
            {
                return byoPhoneNumber(ByoPhoneNumber!);
            }
            else if (IsTwilio && twilio != null)
            {
                return twilio(Twilio!);
            }
            else if (IsVonage && vonage != null)
            {
                return vonage(Vonage!);
            }
            else if (IsVapi && vapi != null)
            {
                return vapi(Vapi!);
            }
            else if (IsTelnyx && telnyx != null)
            {
                return telnyx(Telnyx!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ByoPhoneNumber?>? byoPhoneNumber = null,
            global::System.Action<global::G.TwilioPhoneNumber?>? twilio = null,
            global::System.Action<global::G.VonagePhoneNumber?>? vonage = null,
            global::System.Action<global::G.VapiPhoneNumber?>? vapi = null,
            global::System.Action<global::G.TelnyxPhoneNumber?>? telnyx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsByoPhoneNumber)
            {
                byoPhoneNumber?.Invoke(ByoPhoneNumber!);
            }
            else if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsVonage)
            {
                vonage?.Invoke(Vonage!);
            }
            else if (IsVapi)
            {
                vapi?.Invoke(Vapi!);
            }
            else if (IsTelnyx)
            {
                telnyx?.Invoke(Telnyx!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ByoPhoneNumber,
                typeof(global::G.ByoPhoneNumber),
                Twilio,
                typeof(global::G.TwilioPhoneNumber),
                Vonage,
                typeof(global::G.VonagePhoneNumber),
                Vapi,
                typeof(global::G.VapiPhoneNumber),
                Telnyx,
                typeof(global::G.TelnyxPhoneNumber),
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
        public bool Equals(PhoneNumberControllerUpdateResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ByoPhoneNumber?>.Default.Equals(ByoPhoneNumber, other.ByoPhoneNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TwilioPhoneNumber?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VonagePhoneNumber?>.Default.Equals(Vonage, other.Vonage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VapiPhoneNumber?>.Default.Equals(Vapi, other.Vapi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TelnyxPhoneNumber?>.Default.Equals(Telnyx, other.Telnyx) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoneNumberControllerUpdateResponse obj1, PhoneNumberControllerUpdateResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneNumberControllerUpdateResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoneNumberControllerUpdateResponse obj1, PhoneNumberControllerUpdateResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneNumberControllerUpdateResponse o && Equals(o);
        }
    }
}
