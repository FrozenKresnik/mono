//
// System.Data.SqlTypes.SqlDouble
//
// Author:
//   Tim Coleman <tim@timcoleman.com>
//
// (C) Copyright 2002 Tim Coleman
//

using System;

namespace System.Data.SqlTypes
{
	public struct SqlDouble : INullable, IComparable
	{
		#region Fields
		private double value;

		public static readonly SqlDouble MaxValue = new SqlDouble (1.79E+308);
		public static readonly SqlDouble MinValue = new SqlDouble (-1.79E+308);
		[MonoTODO]
		public static readonly SqlDouble Null;
		public static readonly SqlDouble Zero = new SqlDouble (0);

		#endregion

		#region Constructors

		public SqlDouble (double value) 
		{
			this.value = value;
		}

		#endregion

		#region Properties

		public bool IsNull { 
			get { return (bool) (this == SqlDouble.Null); }
		}

		public double Value { 
			get { return value; }
		}

		#endregion

		#region Methods

		public static SqlDouble Add (SqlDouble x, SqlDouble y)
		{
			return (x + y);
		}

		[MonoTODO]
		public int CompareTo (object value)
		{
			throw new NotImplementedException ();
		}

		public static SqlDouble Divide (SqlDouble x, SqlDouble y)
		{
			return (x / y);
		}

		[MonoTODO]
		public override bool Equals (object value)
		{
			throw new NotImplementedException ();
		}

		public static SqlBoolean Equals (SqlDouble x, SqlDouble y)
		{
			return (x == y);
		}

		public override int GetHashCode ()
		{
			return (int)value;
		}

		public static SqlBoolean GreaterThan (SqlDouble x, SqlDouble y)
		{
			return (x > y);
		}

		public static SqlBoolean GreaterThanOrEqual (SqlDouble x, SqlDouble y)
		{
			return (x >= y);
		}

		public static SqlBoolean LessThan (SqlDouble x, SqlDouble y)
		{
			return (x < y);
		}

		public static SqlBoolean LessThanOrEqual (SqlDouble x, SqlDouble y)
		{
			return (x <= y);
		}

		public static SqlDouble Multiply (SqlDouble x, SqlDouble y)
		{
			return (x * y);
		}

		public static SqlBoolean NotEquals (SqlDouble x, SqlDouble y)
		{
			return (x != y);
		}

		[MonoTODO]
		public static SqlDouble Parse (string s)
		{
			throw new NotImplementedException ();
		}

		public static SqlDouble Subtract (SqlDouble x, SqlDouble y)
		{
			return (x - y);
		}

		public SqlBoolean ToSqlBoolean ()
		{
			return ((SqlBoolean)this);	
		}
		
		public SqlByte ToSqlByte ()
		{
			return ((SqlByte)this);	
		}

		public SqlDecimal ToSqlDecimal ()
		{
			return ((SqlDecimal)this);	
		}

		public SqlInt16 ToSqlInt16 ()
		{
			return ((SqlInt16)this);
		}

		public SqlInt32 ToSqlInt32 ()
		{
			return ((SqlInt32)this);
		}

		public SqlInt64 ToSqlInt64 ()
		{
			return ((SqlInt64)this);
		}

		public SqlMoney ToSqlMoney ()
		{
			return ((SqlMoney)this);
		}

		public SqlSingle ToSqlSingle ()
		{
			return ((SqlSingle)this);
		}

		[MonoTODO]
		public static SqlString ToSqlString ()
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		public override string ToString ()
		{
			throw new NotImplementedException ();
		}

		public static SqlDouble operator + (SqlDouble x, SqlDouble y)
		{
			return new SqlDouble (x.Value + y.Value);
		}

		public static SqlDouble operator / (SqlDouble x, SqlDouble y)
		{
			return new SqlDouble (x.Value / y.Value);
		}

		public static SqlBoolean operator == (SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull) return SqlBoolean.Null;
			return new SqlBoolean (x.Value == y.Value);
		}

		public static SqlBoolean operator > (SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull) return SqlBoolean.Null;
			return new SqlBoolean (x.Value > y.Value);
		}

		public static SqlBoolean operator >= (SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull) return SqlBoolean.Null;
			return new SqlBoolean (x.Value >= y.Value);
		}

		public static SqlBoolean operator != (SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull) return SqlBoolean.Null;
			return new SqlBoolean (!(x.Value == y.Value));
		}

		public static SqlBoolean operator < (SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull) return SqlBoolean.Null;
			return new SqlBoolean (x.Value < y.Value);
		}

		public static SqlBoolean operator <= (SqlDouble x, SqlDouble y)
		{
			if (x.IsNull || y.IsNull) return SqlBoolean.Null;
			return new SqlBoolean (x.Value <= y.Value);
		}

		public static SqlDouble operator * (SqlDouble x, SqlDouble y)
		{
			return new SqlDouble (x.Value * y.Value);
		}

		public static SqlDouble operator - (SqlDouble x, SqlDouble y)
		{
			return new SqlDouble (x.Value - y.Value);
		}

		public static SqlDouble operator - (SqlDouble n)
		{
			return new SqlDouble (-(n.Value));
		}

		public static explicit operator SqlDouble (SqlBoolean x)
		{
			return new SqlDouble ((double)x.ByteValue);
		}

		public static explicit operator double (SqlDouble x)
		{
			return x.Value;
		}

		[MonoTODO]
		public static explicit operator SqlDouble (SqlString x)
		{
			throw new NotImplementedException ();
		}

		public static explicit operator SqlDouble (double x)
		{
			return new SqlDouble (x);
		}

		public static explicit operator SqlDouble (SqlByte x)
		{
			return new SqlDouble ((double)x.Value);
		}

		public static explicit operator SqlDouble (SqlDecimal x)
		{
			return new SqlDouble ((double)x.Value);
		}

		public static explicit operator SqlDouble (SqlInt16 x)
		{
			return new SqlDouble ((double)x.Value);
		}

		public static explicit operator SqlDouble (SqlInt32 x)
		{
			return new SqlDouble ((double)x.Value);
		}

		public static explicit operator SqlDouble (SqlInt64 x)
		{
			return new SqlDouble ((double)x.Value);
		}

		public static explicit operator SqlDouble (SqlMoney x)
		{
			return new SqlDouble ((double)x.Value);
		}

		public static explicit operator SqlDouble (SqlSingle x)
		{
			return new SqlDouble ((double)x.Value);
		}

		#endregion
	}
}
			
