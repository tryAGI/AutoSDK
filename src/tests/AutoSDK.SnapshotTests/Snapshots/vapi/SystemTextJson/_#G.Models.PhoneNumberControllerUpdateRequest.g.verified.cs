//HintName: G.Models.PhoneNumberControllerUpdateRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoneNumberControllerUpdateRequest : global::System.IEquatable<PhoneNumberControllerUpdateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider? Provider { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UpdateByoPhoneNumberDTO? ByoPhoneNumber { get; init; }
#else
        public global::G.UpdateByoPhoneNumberDTO? ByoPhoneNumber { get; }
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
        public global::G.UpdateTwilioPhoneNumberDTO? Twilio { get; init; }
#else
        public global::G.UpdateTwilioPhoneNumberDTO? Twilio { get; }
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
        public global::G.UpdateVonagePhoneNumberDTO? Vonage { get; init; }
#else
        public global::G.UpdateVonagePhoneNumberDTO? Vonage { get; }
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
        public global::G.UpdateVapiPhoneNumberDTO? Vapi { get; init; }
#else
        public global::G.UpdateVapiPhoneNumberDTO? Vapi { get; }
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
        public global::G.UpdateTelnyxPhoneNumberDTO? Telnyx { get; init; }
#else
        public global::G.UpdateTelnyxPhoneNumberDTO? Telnyx { get; }
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
        public static implicit operator PhoneNumberControllerUpdateRequest(global::G.UpdateByoPhoneNumberDTO value) => new PhoneNumberControllerUpdateRequest((global::G.UpdateByoPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateByoPhoneNumberDTO?(PhoneNumberControllerUpdateRequest @this) => @this.ByoPhoneNumber;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(global::G.UpdateByoPhoneNumberDTO? value)
        {
            ByoPhoneNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateRequest(global::G.UpdateTwilioPhoneNumberDTO value) => new PhoneNumberControllerUpdateRequest((global::G.UpdateTwilioPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateTwilioPhoneNumberDTO?(PhoneNumberControllerUpdateRequest @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(global::G.UpdateTwilioPhoneNumberDTO? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateRequest(global::G.UpdateVonagePhoneNumberDTO value) => new PhoneNumberControllerUpdateRequest((global::G.UpdateVonagePhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateVonagePhoneNumberDTO?(PhoneNumberControllerUpdateRequest @this) => @this.Vonage;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(global::G.UpdateVonagePhoneNumberDTO? value)
        {
            Vonage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateRequest(global::G.UpdateVapiPhoneNumberDTO value) => new PhoneNumberControllerUpdateRequest((global::G.UpdateVapiPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateVapiPhoneNumberDTO?(PhoneNumberControllerUpdateRequest @this) => @this.Vapi;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(global::G.UpdateVapiPhoneNumberDTO? value)
        {
            Vapi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateRequest(global::G.UpdateTelnyxPhoneNumberDTO value) => new PhoneNumberControllerUpdateRequest((global::G.UpdateTelnyxPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UpdateTelnyxPhoneNumberDTO?(PhoneNumberControllerUpdateRequest @this) => @this.Telnyx;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(global::G.UpdateTelnyxPhoneNumberDTO? value)
        {
            Telnyx = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(
            global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider? provider,
            global::G.UpdateByoPhoneNumberDTO? byoPhoneNumber,
            global::G.UpdateTwilioPhoneNumberDTO? twilio,
            global::G.UpdateVonagePhoneNumberDTO? vonage,
            global::G.UpdateVapiPhoneNumberDTO? vapi,
            global::G.UpdateTelnyxPhoneNumberDTO? telnyx
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
            global::System.Func<global::G.UpdateByoPhoneNumberDTO?, TResult>? byoPhoneNumber = null,
            global::System.Func<global::G.UpdateTwilioPhoneNumberDTO?, TResult>? twilio = null,
            global::System.Func<global::G.UpdateVonagePhoneNumberDTO?, TResult>? vonage = null,
            global::System.Func<global::G.UpdateVapiPhoneNumberDTO?, TResult>? vapi = null,
            global::System.Func<global::G.UpdateTelnyxPhoneNumberDTO?, TResult>? telnyx = null,
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
            global::System.Action<global::G.UpdateByoPhoneNumberDTO?>? byoPhoneNumber = null,
            global::System.Action<global::G.UpdateTwilioPhoneNumberDTO?>? twilio = null,
            global::System.Action<global::G.UpdateVonagePhoneNumberDTO?>? vonage = null,
            global::System.Action<global::G.UpdateVapiPhoneNumberDTO?>? vapi = null,
            global::System.Action<global::G.UpdateTelnyxPhoneNumberDTO?>? telnyx = null,
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
                typeof(global::G.UpdateByoPhoneNumberDTO),
                Twilio,
                typeof(global::G.UpdateTwilioPhoneNumberDTO),
                Vonage,
                typeof(global::G.UpdateVonagePhoneNumberDTO),
                Vapi,
                typeof(global::G.UpdateVapiPhoneNumberDTO),
                Telnyx,
                typeof(global::G.UpdateTelnyxPhoneNumberDTO),
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
        public bool Equals(PhoneNumberControllerUpdateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateByoPhoneNumberDTO?>.Default.Equals(ByoPhoneNumber, other.ByoPhoneNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateTwilioPhoneNumberDTO?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateVonagePhoneNumberDTO?>.Default.Equals(Vonage, other.Vonage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateVapiPhoneNumberDTO?>.Default.Equals(Vapi, other.Vapi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UpdateTelnyxPhoneNumberDTO?>.Default.Equals(Telnyx, other.Telnyx) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoneNumberControllerUpdateRequest obj1, PhoneNumberControllerUpdateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneNumberControllerUpdateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoneNumberControllerUpdateRequest obj1, PhoneNumberControllerUpdateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneNumberControllerUpdateRequest o && Equals(o);
        }
    }
}
