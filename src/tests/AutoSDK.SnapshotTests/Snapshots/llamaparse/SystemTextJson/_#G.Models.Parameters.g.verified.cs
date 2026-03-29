//HintName: G.Models.Parameters.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Product-specific configuration parameters.
    /// </summary>
    public readonly partial struct Parameters : global::System.IEquatable<Parameters>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ConfigurationCreateRequestParametersDiscriminatorProductType? ProductType { get; }

        /// <summary>
        /// Typed parameters for a *split v1* product configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SplitV1Parameters? SplitV1 { get; init; }
#else
        public global::G.SplitV1Parameters? SplitV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SplitV1))]
#endif
        public bool IsSplitV1 => SplitV1 != null;

        /// <summary>
        /// Typed parameters for an *extract v2* product configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExtractV2Parameters? ExtractV2 { get; init; }
#else
        public global::G.ExtractV2Parameters? ExtractV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExtractV2))]
#endif
        public bool IsExtractV2 => ExtractV2 != null;

        /// <summary>
        /// Typed parameters for a *classify v2* product configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClassifyV2Parameters? ClassifyV2 { get; init; }
#else
        public global::G.ClassifyV2Parameters? ClassifyV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClassifyV2))]
#endif
        public bool IsClassifyV2 => ClassifyV2 != null;

        /// <summary>
        /// Configuration for LlamaParse v2 document parsing.<br/>
        /// Includes tier selection, processing options, output formatting,<br/>
        /// page targeting, and webhook delivery. Refer to the LlamaParse<br/>
        /// documentation for details on each field.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ParseV2Parameters? ParseV2 { get; init; }
#else
        public global::G.ParseV2Parameters? ParseV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ParseV2))]
#endif
        public bool IsParseV2 => ParseV2 != null;

        /// <summary>
        /// Catch-all for configurations without a dedicated typed schema.<br/>
        /// Accepts arbitrary JSON fields alongside ``product_type``.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.UntypedParameters? Unknown { get; init; }
#else
        public global::G.UntypedParameters? Unknown { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unknown))]
#endif
        public bool IsUnknown => Unknown != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Parameters(global::G.SplitV1Parameters value) => new Parameters((global::G.SplitV1Parameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SplitV1Parameters?(Parameters @this) => @this.SplitV1;

        /// <summary>
        /// 
        /// </summary>
        public Parameters(global::G.SplitV1Parameters? value)
        {
            SplitV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Parameters(global::G.ExtractV2Parameters value) => new Parameters((global::G.ExtractV2Parameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExtractV2Parameters?(Parameters @this) => @this.ExtractV2;

        /// <summary>
        /// 
        /// </summary>
        public Parameters(global::G.ExtractV2Parameters? value)
        {
            ExtractV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Parameters(global::G.ClassifyV2Parameters value) => new Parameters((global::G.ClassifyV2Parameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClassifyV2Parameters?(Parameters @this) => @this.ClassifyV2;

        /// <summary>
        /// 
        /// </summary>
        public Parameters(global::G.ClassifyV2Parameters? value)
        {
            ClassifyV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Parameters(global::G.ParseV2Parameters value) => new Parameters((global::G.ParseV2Parameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ParseV2Parameters?(Parameters @this) => @this.ParseV2;

        /// <summary>
        /// 
        /// </summary>
        public Parameters(global::G.ParseV2Parameters? value)
        {
            ParseV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Parameters(global::G.UntypedParameters value) => new Parameters((global::G.UntypedParameters?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.UntypedParameters?(Parameters @this) => @this.Unknown;

        /// <summary>
        /// 
        /// </summary>
        public Parameters(global::G.UntypedParameters? value)
        {
            Unknown = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Parameters(
            global::G.ConfigurationCreateRequestParametersDiscriminatorProductType? productType,
            global::G.SplitV1Parameters? splitV1,
            global::G.ExtractV2Parameters? extractV2,
            global::G.ClassifyV2Parameters? classifyV2,
            global::G.ParseV2Parameters? parseV2,
            global::G.UntypedParameters? unknown
            )
        {
            ProductType = productType;

            SplitV1 = splitV1;
            ExtractV2 = extractV2;
            ClassifyV2 = classifyV2;
            ParseV2 = parseV2;
            Unknown = unknown;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Unknown as object ??
            ParseV2 as object ??
            ClassifyV2 as object ??
            ExtractV2 as object ??
            SplitV1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SplitV1?.ToString() ??
            ExtractV2?.ToString() ??
            ClassifyV2?.ToString() ??
            ParseV2?.ToString() ??
            Unknown?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSplitV1 && !IsExtractV2 && !IsClassifyV2 && !IsParseV2 && !IsUnknown || !IsSplitV1 && IsExtractV2 && !IsClassifyV2 && !IsParseV2 && !IsUnknown || !IsSplitV1 && !IsExtractV2 && IsClassifyV2 && !IsParseV2 && !IsUnknown || !IsSplitV1 && !IsExtractV2 && !IsClassifyV2 && IsParseV2 && !IsUnknown || !IsSplitV1 && !IsExtractV2 && !IsClassifyV2 && !IsParseV2 && IsUnknown;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SplitV1Parameters?, TResult>? splitV1 = null,
            global::System.Func<global::G.ExtractV2Parameters?, TResult>? extractV2 = null,
            global::System.Func<global::G.ClassifyV2Parameters?, TResult>? classifyV2 = null,
            global::System.Func<global::G.ParseV2Parameters?, TResult>? parseV2 = null,
            global::System.Func<global::G.UntypedParameters?, TResult>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSplitV1 && splitV1 != null)
            {
                return splitV1(SplitV1!);
            }
            else if (IsExtractV2 && extractV2 != null)
            {
                return extractV2(ExtractV2!);
            }
            else if (IsClassifyV2 && classifyV2 != null)
            {
                return classifyV2(ClassifyV2!);
            }
            else if (IsParseV2 && parseV2 != null)
            {
                return parseV2(ParseV2!);
            }
            else if (IsUnknown && unknown != null)
            {
                return unknown(Unknown!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SplitV1Parameters?>? splitV1 = null,
            global::System.Action<global::G.ExtractV2Parameters?>? extractV2 = null,
            global::System.Action<global::G.ClassifyV2Parameters?>? classifyV2 = null,
            global::System.Action<global::G.ParseV2Parameters?>? parseV2 = null,
            global::System.Action<global::G.UntypedParameters?>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSplitV1)
            {
                splitV1?.Invoke(SplitV1!);
            }
            else if (IsExtractV2)
            {
                extractV2?.Invoke(ExtractV2!);
            }
            else if (IsClassifyV2)
            {
                classifyV2?.Invoke(ClassifyV2!);
            }
            else if (IsParseV2)
            {
                parseV2?.Invoke(ParseV2!);
            }
            else if (IsUnknown)
            {
                unknown?.Invoke(Unknown!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SplitV1,
                typeof(global::G.SplitV1Parameters),
                ExtractV2,
                typeof(global::G.ExtractV2Parameters),
                ClassifyV2,
                typeof(global::G.ClassifyV2Parameters),
                ParseV2,
                typeof(global::G.ParseV2Parameters),
                Unknown,
                typeof(global::G.UntypedParameters),
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
        public bool Equals(Parameters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SplitV1Parameters?>.Default.Equals(SplitV1, other.SplitV1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExtractV2Parameters?>.Default.Equals(ExtractV2, other.ExtractV2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ClassifyV2Parameters?>.Default.Equals(ClassifyV2, other.ClassifyV2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ParseV2Parameters?>.Default.Equals(ParseV2, other.ParseV2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.UntypedParameters?>.Default.Equals(Unknown, other.Unknown) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Parameters obj1, Parameters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Parameters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Parameters obj1, Parameters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Parameters o && Equals(o);
        }
    }
}
