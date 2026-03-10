//HintName: G.Models.TransferDestinationVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransferDestinationVariant1 : global::System.IEquatable<TransferDestinationVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PhoneNumberTransferDestination? Phone { get; init; }
#else
        public global::G.PhoneNumberTransferDestination? Phone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Phone))]
#endif
        public bool IsPhone => Phone != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SIPUriTransferDestination? SipUri { get; init; }
#else
        public global::G.SIPUriTransferDestination? SipUri { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipUri))]
#endif
        public bool IsSipUri => SipUri != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PhoneNumberDynamicVariableTransferDestination? PhoneDynamicVariable { get; init; }
#else
        public global::G.PhoneNumberDynamicVariableTransferDestination? PhoneDynamicVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PhoneDynamicVariable))]
#endif
        public bool IsPhoneDynamicVariable => PhoneDynamicVariable != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SIPUriDynamicVariableTransferDestination? SipUriDynamicVariable { get; init; }
#else
        public global::G.SIPUriDynamicVariableTransferDestination? SipUriDynamicVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipUriDynamicVariable))]
#endif
        public bool IsSipUriDynamicVariable => SipUriDynamicVariable != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferDestinationVariant1(global::G.PhoneNumberTransferDestination value) => new TransferDestinationVariant1((global::G.PhoneNumberTransferDestination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PhoneNumberTransferDestination?(TransferDestinationVariant1 @this) => @this.Phone;

        /// <summary>
        /// 
        /// </summary>
        public TransferDestinationVariant1(global::G.PhoneNumberTransferDestination? value)
        {
            Phone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferDestinationVariant1(global::G.SIPUriTransferDestination value) => new TransferDestinationVariant1((global::G.SIPUriTransferDestination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SIPUriTransferDestination?(TransferDestinationVariant1 @this) => @this.SipUri;

        /// <summary>
        /// 
        /// </summary>
        public TransferDestinationVariant1(global::G.SIPUriTransferDestination? value)
        {
            SipUri = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferDestinationVariant1(global::G.PhoneNumberDynamicVariableTransferDestination value) => new TransferDestinationVariant1((global::G.PhoneNumberDynamicVariableTransferDestination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PhoneNumberDynamicVariableTransferDestination?(TransferDestinationVariant1 @this) => @this.PhoneDynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public TransferDestinationVariant1(global::G.PhoneNumberDynamicVariableTransferDestination? value)
        {
            PhoneDynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferDestinationVariant1(global::G.SIPUriDynamicVariableTransferDestination value) => new TransferDestinationVariant1((global::G.SIPUriDynamicVariableTransferDestination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SIPUriDynamicVariableTransferDestination?(TransferDestinationVariant1 @this) => @this.SipUriDynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public TransferDestinationVariant1(global::G.SIPUriDynamicVariableTransferDestination? value)
        {
            SipUriDynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TransferDestinationVariant1(
            global::G.PhoneNumberTransferTransferDestinationVariant1DiscriminatorType? type,
            global::G.PhoneNumberTransferDestination? phone,
            global::G.SIPUriTransferDestination? sipUri,
            global::G.PhoneNumberDynamicVariableTransferDestination? phoneDynamicVariable,
            global::G.SIPUriDynamicVariableTransferDestination? sipUriDynamicVariable
            )
        {
            Type = type;

            Phone = phone;
            SipUri = sipUri;
            PhoneDynamicVariable = phoneDynamicVariable;
            SipUriDynamicVariable = sipUriDynamicVariable;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SipUriDynamicVariable as object ??
            PhoneDynamicVariable as object ??
            SipUri as object ??
            Phone as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Phone?.ToString() ??
            SipUri?.ToString() ??
            PhoneDynamicVariable?.ToString() ??
            SipUriDynamicVariable?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPhone && !IsSipUri && !IsPhoneDynamicVariable && !IsSipUriDynamicVariable || !IsPhone && IsSipUri && !IsPhoneDynamicVariable && !IsSipUriDynamicVariable || !IsPhone && !IsSipUri && IsPhoneDynamicVariable && !IsSipUriDynamicVariable || !IsPhone && !IsSipUri && !IsPhoneDynamicVariable && IsSipUriDynamicVariable;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PhoneNumberTransferDestination?, TResult>? phone = null,
            global::System.Func<global::G.SIPUriTransferDestination?, TResult>? sipUri = null,
            global::System.Func<global::G.PhoneNumberDynamicVariableTransferDestination?, TResult>? phoneDynamicVariable = null,
            global::System.Func<global::G.SIPUriDynamicVariableTransferDestination?, TResult>? sipUriDynamicVariable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPhone && phone != null)
            {
                return phone(Phone!);
            }
            else if (IsSipUri && sipUri != null)
            {
                return sipUri(SipUri!);
            }
            else if (IsPhoneDynamicVariable && phoneDynamicVariable != null)
            {
                return phoneDynamicVariable(PhoneDynamicVariable!);
            }
            else if (IsSipUriDynamicVariable && sipUriDynamicVariable != null)
            {
                return sipUriDynamicVariable(SipUriDynamicVariable!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PhoneNumberTransferDestination?>? phone = null,
            global::System.Action<global::G.SIPUriTransferDestination?>? sipUri = null,
            global::System.Action<global::G.PhoneNumberDynamicVariableTransferDestination?>? phoneDynamicVariable = null,
            global::System.Action<global::G.SIPUriDynamicVariableTransferDestination?>? sipUriDynamicVariable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPhone)
            {
                phone?.Invoke(Phone!);
            }
            else if (IsSipUri)
            {
                sipUri?.Invoke(SipUri!);
            }
            else if (IsPhoneDynamicVariable)
            {
                phoneDynamicVariable?.Invoke(PhoneDynamicVariable!);
            }
            else if (IsSipUriDynamicVariable)
            {
                sipUriDynamicVariable?.Invoke(SipUriDynamicVariable!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Phone,
                typeof(global::G.PhoneNumberTransferDestination),
                SipUri,
                typeof(global::G.SIPUriTransferDestination),
                PhoneDynamicVariable,
                typeof(global::G.PhoneNumberDynamicVariableTransferDestination),
                SipUriDynamicVariable,
                typeof(global::G.SIPUriDynamicVariableTransferDestination),
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
        public bool Equals(TransferDestinationVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PhoneNumberTransferDestination?>.Default.Equals(Phone, other.Phone) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SIPUriTransferDestination?>.Default.Equals(SipUri, other.SipUri) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PhoneNumberDynamicVariableTransferDestination?>.Default.Equals(PhoneDynamicVariable, other.PhoneDynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SIPUriDynamicVariableTransferDestination?>.Default.Equals(SipUriDynamicVariable, other.SipUriDynamicVariable) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransferDestinationVariant1 obj1, TransferDestinationVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransferDestinationVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransferDestinationVariant1 obj1, TransferDestinationVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransferDestinationVariant1 o && Equals(o);
        }
    }
}
