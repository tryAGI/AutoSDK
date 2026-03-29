//HintName: G.Models.SourcesItem3.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SourcesItem3 : global::System.IEquatable<SourcesItem3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind? Kind { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FileSourceRequest? File { get; init; }
#else
        public global::G.FileSourceRequest? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HttpSourceRequest? Http { get; init; }
#else
        public global::G.HttpSourceRequest? Http { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Http))]
#endif
        public bool IsHttp => Http != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.S3SourceRequest? S3 { get; init; }
#else
        public global::G.S3SourceRequest? S3 { get; }
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
        public static implicit operator SourcesItem3(global::G.FileSourceRequest value) => new SourcesItem3((global::G.FileSourceRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FileSourceRequest?(SourcesItem3 @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public SourcesItem3(global::G.FileSourceRequest? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SourcesItem3(global::G.HttpSourceRequest value) => new SourcesItem3((global::G.HttpSourceRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HttpSourceRequest?(SourcesItem3 @this) => @this.Http;

        /// <summary>
        /// 
        /// </summary>
        public SourcesItem3(global::G.HttpSourceRequest? value)
        {
            Http = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SourcesItem3(global::G.S3SourceRequest value) => new SourcesItem3((global::G.S3SourceRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.S3SourceRequest?(SourcesItem3 @this) => @this.S3;

        /// <summary>
        /// 
        /// </summary>
        public SourcesItem3(global::G.S3SourceRequest? value)
        {
            S3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SourcesItem3(
            global::G.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKind? kind,
            global::G.FileSourceRequest? file,
            global::G.HttpSourceRequest? http,
            global::G.S3SourceRequest? s3
            )
        {
            Kind = kind;

            File = file;
            Http = http;
            S3 = s3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            S3 as object ??
            Http as object ??
            File as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            File?.ToString() ??
            Http?.ToString() ??
            S3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFile && !IsHttp && !IsS3 || !IsFile && IsHttp && !IsS3 || !IsFile && !IsHttp && IsS3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.FileSourceRequest?, TResult>? file = null,
            global::System.Func<global::G.HttpSourceRequest?, TResult>? http = null,
            global::System.Func<global::G.S3SourceRequest?, TResult>? s3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsHttp && http != null)
            {
                return http(Http!);
            }
            else if (IsS3 && s3 != null)
            {
                return s3(S3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.FileSourceRequest?>? file = null,
            global::System.Action<global::G.HttpSourceRequest?>? http = null,
            global::System.Action<global::G.S3SourceRequest?>? s3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsHttp)
            {
                http?.Invoke(Http!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                File,
                typeof(global::G.FileSourceRequest),
                Http,
                typeof(global::G.HttpSourceRequest),
                S3,
                typeof(global::G.S3SourceRequest),
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
        public bool Equals(SourcesItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.FileSourceRequest?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::G.HttpSourceRequest?>.Default.Equals(Http, other.Http) &&
                global::System.Collections.Generic.EqualityComparer<global::G.S3SourceRequest?>.Default.Equals(S3, other.S3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SourcesItem3 obj1, SourcesItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SourcesItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SourcesItem3 obj1, SourcesItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SourcesItem3 o && Equals(o);
        }
    }
}
