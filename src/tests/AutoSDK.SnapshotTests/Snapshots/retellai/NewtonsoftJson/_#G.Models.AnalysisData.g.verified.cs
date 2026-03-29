//HintName: G.Models.AnalysisData.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnalysisData : global::System.IEquatable<AnalysisData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StringAnalysisData? String { get; init; }
#else
        public global::G.StringAnalysisData? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EnumAnalysisData? Enum { get; init; }
#else
        public global::G.EnumAnalysisData? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BooleanAnalysisData? Boolean { get; init; }
#else
        public global::G.BooleanAnalysisData? Boolean { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Boolean))]
#endif
        public bool IsBoolean => Boolean != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NumberAnalysisData? Number { get; init; }
#else
        public global::G.NumberAnalysisData? Number { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Number))]
#endif
        public bool IsNumber => Number != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalysisData(global::G.StringAnalysisData value) => new AnalysisData((global::G.StringAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StringAnalysisData?(AnalysisData @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public AnalysisData(global::G.StringAnalysisData? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalysisData(global::G.EnumAnalysisData value) => new AnalysisData((global::G.EnumAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EnumAnalysisData?(AnalysisData @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public AnalysisData(global::G.EnumAnalysisData? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalysisData(global::G.BooleanAnalysisData value) => new AnalysisData((global::G.BooleanAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BooleanAnalysisData?(AnalysisData @this) => @this.Boolean;

        /// <summary>
        /// 
        /// </summary>
        public AnalysisData(global::G.BooleanAnalysisData? value)
        {
            Boolean = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalysisData(global::G.NumberAnalysisData value) => new AnalysisData((global::G.NumberAnalysisData?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NumberAnalysisData?(AnalysisData @this) => @this.Number;

        /// <summary>
        /// 
        /// </summary>
        public AnalysisData(global::G.NumberAnalysisData? value)
        {
            Number = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnalysisData(
            global::G.StringAnalysisData? @string,
            global::G.EnumAnalysisData? @enum,
            global::G.BooleanAnalysisData? boolean,
            global::G.NumberAnalysisData? number
            )
        {
            String = @string;
            Enum = @enum;
            Boolean = boolean;
            Number = number;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Number as object ??
            Boolean as object ??
            Enum as object ??
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            Enum?.ToString() ??
            Boolean?.ToString() ??
            Number?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsEnum && !IsBoolean && !IsNumber || !IsString && IsEnum && !IsBoolean && !IsNumber || !IsString && !IsEnum && IsBoolean && !IsNumber || !IsString && !IsEnum && !IsBoolean && IsNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.StringAnalysisData?, TResult>? @string = null,
            global::System.Func<global::G.EnumAnalysisData?, TResult>? @enum = null,
            global::System.Func<global::G.BooleanAnalysisData?, TResult>? boolean = null,
            global::System.Func<global::G.NumberAnalysisData?, TResult>? number = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsBoolean && boolean != null)
            {
                return boolean(Boolean!);
            }
            else if (IsNumber && number != null)
            {
                return number(Number!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.StringAnalysisData?>? @string = null,
            global::System.Action<global::G.EnumAnalysisData?>? @enum = null,
            global::System.Action<global::G.BooleanAnalysisData?>? boolean = null,
            global::System.Action<global::G.NumberAnalysisData?>? number = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsNumber)
            {
                number?.Invoke(Number!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::G.StringAnalysisData),
                Enum,
                typeof(global::G.EnumAnalysisData),
                Boolean,
                typeof(global::G.BooleanAnalysisData),
                Number,
                typeof(global::G.NumberAnalysisData),
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
        public bool Equals(AnalysisData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.StringAnalysisData?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EnumAnalysisData?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BooleanAnalysisData?>.Default.Equals(Boolean, other.Boolean) &&
                global::System.Collections.Generic.EqualityComparer<global::G.NumberAnalysisData?>.Default.Equals(Number, other.Number) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnalysisData obj1, AnalysisData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnalysisData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnalysisData obj1, AnalysisData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnalysisData o && Equals(o);
        }
    }
}
