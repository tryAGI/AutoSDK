//HintName: G.Models.FileSearchServerToolFiltersOneOf0Value.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FileSearchServerToolFiltersOneOf0Value : global::System.IEquatable<FileSearchServerToolFiltersOneOf0Value>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value1 { get; init; }
#else
        public string? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? Value2 { get; init; }
#else
        public double? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? Value3 { get; init; }
#else
        public bool? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>? FileSearchServerToolFiltersOneOf0Value3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>? FileSearchServerToolFiltersOneOf0Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchServerToolFiltersOneOf0Value3))]
#endif
        public bool IsFileSearchServerToolFiltersOneOf0Value3 => FileSearchServerToolFiltersOneOf0Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileSearchServerToolFiltersOneOf0Value(string value) => new FileSearchServerToolFiltersOneOf0Value((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(FileSearchServerToolFiltersOneOf0Value @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFiltersOneOf0Value(string? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileSearchServerToolFiltersOneOf0Value(double value) => new FileSearchServerToolFiltersOneOf0Value((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(FileSearchServerToolFiltersOneOf0Value @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFiltersOneOf0Value(double? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FileSearchServerToolFiltersOneOf0Value(bool value) => new FileSearchServerToolFiltersOneOf0Value((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(FileSearchServerToolFiltersOneOf0Value @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFiltersOneOf0Value(bool? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FileSearchServerToolFiltersOneOf0Value(
            string? value1,
            double? value2,
            bool? value3,
            global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>? fileSearchServerToolFiltersOneOf0Value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            FileSearchServerToolFiltersOneOf0Value3 = fileSearchServerToolFiltersOneOf0Value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FileSearchServerToolFiltersOneOf0Value3 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString().ToLowerInvariant() ??
            FileSearchServerToolFiltersOneOf0Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsFileSearchServerToolFiltersOneOf0Value3 || !IsValue1 && IsValue2 && !IsValue3 && !IsFileSearchServerToolFiltersOneOf0Value3 || !IsValue1 && !IsValue2 && IsValue3 && !IsFileSearchServerToolFiltersOneOf0Value3 || !IsValue1 && !IsValue2 && !IsValue3 && IsFileSearchServerToolFiltersOneOf0Value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? value1 = null,
            global::System.Func<double?, TResult>? value2 = null,
            global::System.Func<bool?, TResult>? value3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>?, TResult>? fileSearchServerToolFiltersOneOf0Value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsFileSearchServerToolFiltersOneOf0Value3 && fileSearchServerToolFiltersOneOf0Value3 != null)
            {
                return fileSearchServerToolFiltersOneOf0Value3(FileSearchServerToolFiltersOneOf0Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? value1 = null,
            global::System.Action<double?>? value2 = null,
            global::System.Action<bool?>? value3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>?>? fileSearchServerToolFiltersOneOf0Value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsFileSearchServerToolFiltersOneOf0Value3)
            {
                fileSearchServerToolFiltersOneOf0Value3?.Invoke(FileSearchServerToolFiltersOneOf0Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(string),
                Value2,
                typeof(double),
                Value3,
                typeof(bool),
                FileSearchServerToolFiltersOneOf0Value3,
                typeof(global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>),
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
        public bool Equals(FileSearchServerToolFiltersOneOf0Value other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.FileSearchServerToolFiltersOneOf0ValueOneOf3Items>?>.Default.Equals(FileSearchServerToolFiltersOneOf0Value3, other.FileSearchServerToolFiltersOneOf0Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FileSearchServerToolFiltersOneOf0Value obj1, FileSearchServerToolFiltersOneOf0Value obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FileSearchServerToolFiltersOneOf0Value>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FileSearchServerToolFiltersOneOf0Value obj1, FileSearchServerToolFiltersOneOf0Value obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileSearchServerToolFiltersOneOf0Value o && Equals(o);
        }
    }
}
