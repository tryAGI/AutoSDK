//HintName: G.Models.PhoneNumberControllerCreateRequest.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoneNumberControllerCreateRequest : global::System.IEquatable<PhoneNumberControllerCreateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider? Provider { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateByoPhoneNumberDTO? ByoPhoneNumber { get; init; }
#else
        public global::G.CreateByoPhoneNumberDTO? ByoPhoneNumber { get; }
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
        public global::G.CreateTwilioPhoneNumberDTO? Twilio { get; init; }
#else
        public global::G.CreateTwilioPhoneNumberDTO? Twilio { get; }
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
        public global::G.CreateVonagePhoneNumberDTO? Vonage { get; init; }
#else
        public global::G.CreateVonagePhoneNumberDTO? Vonage { get; }
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
        public global::G.CreateVapiPhoneNumberDTO? Vapi { get; init; }
#else
        public global::G.CreateVapiPhoneNumberDTO? Vapi { get; }
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
        public global::G.CreateTelnyxPhoneNumberDTO? Telnyx { get; init; }
#else
        public global::G.CreateTelnyxPhoneNumberDTO? Telnyx { get; }
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
        public static implicit operator PhoneNumberControllerCreateRequest(global::G.CreateByoPhoneNumberDTO value) => new PhoneNumberControllerCreateRequest((global::G.CreateByoPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateByoPhoneNumberDTO?(PhoneNumberControllerCreateRequest @this) => @this.ByoPhoneNumber;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(global::G.CreateByoPhoneNumberDTO? value)
        {
            ByoPhoneNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerCreateRequest(global::G.CreateTwilioPhoneNumberDTO value) => new PhoneNumberControllerCreateRequest((global::G.CreateTwilioPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTwilioPhoneNumberDTO?(PhoneNumberControllerCreateRequest @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(global::G.CreateTwilioPhoneNumberDTO? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerCreateRequest(global::G.CreateVonagePhoneNumberDTO value) => new PhoneNumberControllerCreateRequest((global::G.CreateVonagePhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateVonagePhoneNumberDTO?(PhoneNumberControllerCreateRequest @this) => @this.Vonage;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(global::G.CreateVonagePhoneNumberDTO? value)
        {
            Vonage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerCreateRequest(global::G.CreateVapiPhoneNumberDTO value) => new PhoneNumberControllerCreateRequest((global::G.CreateVapiPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateVapiPhoneNumberDTO?(PhoneNumberControllerCreateRequest @this) => @this.Vapi;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(global::G.CreateVapiPhoneNumberDTO? value)
        {
            Vapi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerCreateRequest(global::G.CreateTelnyxPhoneNumberDTO value) => new PhoneNumberControllerCreateRequest((global::G.CreateTelnyxPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateTelnyxPhoneNumberDTO?(PhoneNumberControllerCreateRequest @this) => @this.Telnyx;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(global::G.CreateTelnyxPhoneNumberDTO? value)
        {
            Telnyx = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(
            global::G.PhoneNumberControllerCreateRequestDiscriminatorProvider? provider,
            global::G.CreateByoPhoneNumberDTO? byoPhoneNumber,
            global::G.CreateTwilioPhoneNumberDTO? twilio,
            global::G.CreateVonagePhoneNumberDTO? vonage,
            global::G.CreateVapiPhoneNumberDTO? vapi,
            global::G.CreateTelnyxPhoneNumberDTO? telnyx
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
            global::System.Func<global::G.CreateByoPhoneNumberDTO?, TResult>? byoPhoneNumber = null,
            global::System.Func<global::G.CreateTwilioPhoneNumberDTO?, TResult>? twilio = null,
            global::System.Func<global::G.CreateVonagePhoneNumberDTO?, TResult>? vonage = null,
            global::System.Func<global::G.CreateVapiPhoneNumberDTO?, TResult>? vapi = null,
            global::System.Func<global::G.CreateTelnyxPhoneNumberDTO?, TResult>? telnyx = null,
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
            global::System.Action<global::G.CreateByoPhoneNumberDTO?>? byoPhoneNumber = null,
            global::System.Action<global::G.CreateTwilioPhoneNumberDTO?>? twilio = null,
            global::System.Action<global::G.CreateVonagePhoneNumberDTO?>? vonage = null,
            global::System.Action<global::G.CreateVapiPhoneNumberDTO?>? vapi = null,
            global::System.Action<global::G.CreateTelnyxPhoneNumberDTO?>? telnyx = null,
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
                typeof(global::G.CreateByoPhoneNumberDTO),
                Twilio,
                typeof(global::G.CreateTwilioPhoneNumberDTO),
                Vonage,
                typeof(global::G.CreateVonagePhoneNumberDTO),
                Vapi,
                typeof(global::G.CreateVapiPhoneNumberDTO),
                Telnyx,
                typeof(global::G.CreateTelnyxPhoneNumberDTO),
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
        public bool Equals(PhoneNumberControllerCreateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateByoPhoneNumberDTO?>.Default.Equals(ByoPhoneNumber, other.ByoPhoneNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTwilioPhoneNumberDTO?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateVonagePhoneNumberDTO?>.Default.Equals(Vonage, other.Vonage) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateVapiPhoneNumberDTO?>.Default.Equals(Vapi, other.Vapi) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateTelnyxPhoneNumberDTO?>.Default.Equals(Telnyx, other.Telnyx) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoneNumberControllerCreateRequest obj1, PhoneNumberControllerCreateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneNumberControllerCreateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoneNumberControllerCreateRequest obj1, PhoneNumberControllerCreateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneNumberControllerCreateRequest o && Equals(o);
        }
    }
}
