//HintName: G.Models.Target3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Specification for the type of output target.<br/>
    /// Default Value: {"kind":"inbody"}
    /// </summary>
    public readonly partial struct Target3 : global::System.IEquatable<Target3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind? Kind { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InBodyTarget? Inbody { get; init; }
#else
        public global::G.InBodyTarget? Inbody { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inbody))]
#endif
        public bool IsInbody => Inbody != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ZipTarget? Zip { get; init; }
#else
        public global::G.ZipTarget? Zip { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Zip))]
#endif
        public bool IsZip => Zip != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.S3Target? S3 { get; init; }
#else
        public global::G.S3Target? S3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(S3))]
#endif
        public bool IsS3 => S3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PutTarget? Put { get; init; }
#else
        public global::G.PutTarget? Put { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Put))]
#endif
        public bool IsPut => Put != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Target3(global::G.InBodyTarget value) => new Target3((global::G.InBodyTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InBodyTarget?(Target3 @this) => @this.Inbody;

        /// <summary>
        /// 
        /// </summary>
        public Target3(global::G.InBodyTarget? value)
        {
            Inbody = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Target3(global::G.ZipTarget value) => new Target3((global::G.ZipTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ZipTarget?(Target3 @this) => @this.Zip;

        /// <summary>
        /// 
        /// </summary>
        public Target3(global::G.ZipTarget? value)
        {
            Zip = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Target3(global::G.S3Target value) => new Target3((global::G.S3Target?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.S3Target?(Target3 @this) => @this.S3;

        /// <summary>
        /// 
        /// </summary>
        public Target3(global::G.S3Target? value)
        {
            S3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Target3(global::G.PutTarget value) => new Target3((global::G.PutTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PutTarget?(Target3 @this) => @this.Put;

        /// <summary>
        /// 
        /// </summary>
        public Target3(global::G.PutTarget? value)
        {
            Put = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Target3(
            global::G.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKind? kind,
            global::G.InBodyTarget? inbody,
            global::G.ZipTarget? zip,
            global::G.S3Target? s3,
            global::G.PutTarget? put
            )
        {
            Kind = kind;

            Inbody = inbody;
            Zip = zip;
            S3 = s3;
            Put = put;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Put as object ??
            S3 as object ??
            Zip as object ??
            Inbody as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Inbody?.ToString() ??
            Zip?.ToString() ??
            S3?.ToString() ??
            Put?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInbody && !IsZip && !IsS3 && !IsPut || !IsInbody && IsZip && !IsS3 && !IsPut || !IsInbody && !IsZip && IsS3 && !IsPut || !IsInbody && !IsZip && !IsS3 && IsPut;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.InBodyTarget?, TResult>? inbody = null,
            global::System.Func<global::G.ZipTarget?, TResult>? zip = null,
            global::System.Func<global::G.S3Target?, TResult>? s3 = null,
            global::System.Func<global::G.PutTarget?, TResult>? put = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInbody && inbody != null)
            {
                return inbody(Inbody!);
            }
            else if (IsZip && zip != null)
            {
                return zip(Zip!);
            }
            else if (IsS3 && s3 != null)
            {
                return s3(S3!);
            }
            else if (IsPut && put != null)
            {
                return put(Put!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.InBodyTarget?>? inbody = null,
            global::System.Action<global::G.ZipTarget?>? zip = null,
            global::System.Action<global::G.S3Target?>? s3 = null,
            global::System.Action<global::G.PutTarget?>? put = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInbody)
            {
                inbody?.Invoke(Inbody!);
            }
            else if (IsZip)
            {
                zip?.Invoke(Zip!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsPut)
            {
                put?.Invoke(Put!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Inbody,
                typeof(global::G.InBodyTarget),
                Zip,
                typeof(global::G.ZipTarget),
                S3,
                typeof(global::G.S3Target),
                Put,
                typeof(global::G.PutTarget),
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
        public bool Equals(Target3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.InBodyTarget?>.Default.Equals(Inbody, other.Inbody) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ZipTarget?>.Default.Equals(Zip, other.Zip) &&
                global::System.Collections.Generic.EqualityComparer<global::G.S3Target?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PutTarget?>.Default.Equals(Put, other.Put) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Target3 obj1, Target3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Target3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Target3 obj1, Target3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Target3 o && Equals(o);
        }
    }
}
