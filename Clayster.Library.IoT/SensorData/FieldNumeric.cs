using System;
using System.Collections.Generic;
using System.Text;
using Clayster.Library.Internet;
using Clayster.Library.Internet.JSON;
using Clayster.Library.Internet.HTTP;
using Clayster.Library.Internet.Semantic.Turtle;

namespace Clayster.Library.IoT.SensorData
{
	/// <summary>
	/// Numeric valued field.
	/// </summary>
	/// <remarks>
	/// � Clayster, 2007-2014
	/// 
	/// Author: Peter Waher
	/// </remarks>
	[CLSCompliant(true)]
	[Serializable]
	public class FieldNumeric : Field
	{
		private string unit;
		private double value;
		private int nrDecimals;

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type)
			: base(NodeId, FieldName, StringId, Timepoint, Type)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, DateTime Timepoint,
			long Value, ReadoutType Type)
			: base(NodeId, FieldName, StringId, Timepoint, Type)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type)
			: base(NodeId, FieldName, StringIds, Timepoint, Type)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		public FieldNumeric(string NodeId, string FieldName, FieldLanguageStep[] StringIds, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type)
			: base(NodeId, FieldName, StringIds, Timepoint, Type)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, DateTime Timepoint,
			long Value, ReadoutType Type)
			: base(NodeId, FieldName, StringIds, Timepoint, Type)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		public FieldNumeric(string NodeId, string FieldName, FieldLanguageStep[] StringIds, DateTime Timepoint,
			long Value, ReadoutType Type)
			: base(NodeId, FieldName, StringIds, Timepoint, Type)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, string LocalizationSeed, 
			DateTime Timepoint, double Value, int NrDecimals, string Unit, ReadoutType Type)
			: base(NodeId, FieldName, StringId, LocalizationSeed, Timepoint, Type)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, string LocalizationSeed, 
			DateTime Timepoint, long Value, ReadoutType Type)
			: base(NodeId, FieldName, StringId, LocalizationSeed, Timepoint, Type)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, string LocalizationSeed, 
			DateTime Timepoint, double Value, int NrDecimals, string Unit, ReadoutType Type)
			: base(NodeId, FieldName, StringIds, LocalizationSeed, Timepoint, Type)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, string LocalizationSeed, 
			DateTime Timepoint, long Value, ReadoutType Type)
			: base(NodeId, FieldName, StringIds, LocalizationSeed, Timepoint, Type)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type, string LanguageModule)
			: base(NodeId, FieldName, StringId, Timepoint, Type, LanguageModule)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, DateTime Timepoint,
			long Value, ReadoutType Type, string LanguageModule)
			: base(NodeId, FieldName, StringId, Timepoint, Type, LanguageModule)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type, string LanguageModule)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, LanguageModule)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, FieldLanguageStep[] StringIds, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type, string LanguageModule)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, LanguageModule)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, DateTime Timepoint,
			long Value, ReadoutType Type, string LanguageModule)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, LanguageModule)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, FieldLanguageStep[] StringIds, DateTime Timepoint,
			long Value, ReadoutType Type, string LanguageModule)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, LanguageModule)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, string LocalizationSeed,
			DateTime Timepoint, double Value, int NrDecimals, string Unit, ReadoutType Type, string LanguageModule)
			: base(NodeId, FieldName, StringId, LocalizationSeed, Timepoint, Type, LanguageModule)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, string LocalizationSeed,
			DateTime Timepoint, long Value, ReadoutType Type, string LanguageModule)
			: base(NodeId, FieldName, StringId, LocalizationSeed, Timepoint, Type, LanguageModule)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, string LocalizationSeed,
			DateTime Timepoint, double Value, int NrDecimals, string Unit, ReadoutType Type, string LanguageModule)
			: base(NodeId, FieldName, StringIds, LocalizationSeed, Timepoint, Type, LanguageModule)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, string LocalizationSeed,
			DateTime Timepoint, long Value, ReadoutType Type, string LanguageModule)
			: base(NodeId, FieldName, StringIds, LocalizationSeed, Timepoint, Type, LanguageModule)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}
	
		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type, FieldStatus Status)
			: base(NodeId, FieldName, StringId, Timepoint, Type, Status)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, DateTime Timepoint,
			long Value, ReadoutType Type, FieldStatus Status)
			: base(NodeId, FieldName, StringId, Timepoint, Type, Status)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type, FieldStatus Status)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, Status)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		public FieldNumeric(string NodeId, string FieldName, FieldLanguageStep[] StringIds, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type, FieldStatus Status)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, Status)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, DateTime Timepoint,
			long Value, ReadoutType Type, FieldStatus Status)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, Status)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		public FieldNumeric(string NodeId, string FieldName, FieldLanguageStep[] StringIds, DateTime Timepoint,
			long Value, ReadoutType Type, FieldStatus Status)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, Status)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, string LocalizationSeed,
			DateTime Timepoint, double Value, int NrDecimals, string Unit, ReadoutType Type, FieldStatus Status)
			: base(NodeId, FieldName, StringId, LocalizationSeed, Timepoint, Type, Status)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, string LocalizationSeed,
			DateTime Timepoint, long Value, ReadoutType Type, FieldStatus Status)
			: base(NodeId, FieldName, StringId, LocalizationSeed, Timepoint, Type, Status)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, string LocalizationSeed,
			DateTime Timepoint, double Value, int NrDecimals, string Unit, ReadoutType Type, FieldStatus Status)
			: base(NodeId, FieldName, StringIds, LocalizationSeed, Timepoint, Type, Status)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, string LocalizationSeed,
			DateTime Timepoint, long Value, ReadoutType Type, FieldStatus Status)
			: base(NodeId, FieldName, StringIds, LocalizationSeed, Timepoint, Type, Status)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type, FieldStatus Status, string LanguageModule)
			: base(NodeId, FieldName, StringId, Timepoint, Type, Status, LanguageModule)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, DateTime Timepoint,
			long Value, ReadoutType Type, FieldStatus Status, string LanguageModule)
			: base(NodeId, FieldName, StringId, Timepoint, Type, Status, LanguageModule)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type, FieldStatus Status, string LanguageModule)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, Status, LanguageModule)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, FieldLanguageStep[] StringIds, DateTime Timepoint,
			double Value, int NrDecimals, string Unit, ReadoutType Type, FieldStatus Status, string LanguageModule)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, Status, LanguageModule)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, DateTime Timepoint,
			long Value, ReadoutType Type, FieldStatus Status, string LanguageModule)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, Status, LanguageModule)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, FieldLanguageStep[] StringIds, DateTime Timepoint,
			long Value, ReadoutType Type, FieldStatus Status, string LanguageModule)
			: base(NodeId, FieldName, StringIds, Timepoint, Type, Status, LanguageModule)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, string LocalizationSeed,
			DateTime Timepoint, double Value, int NrDecimals, string Unit, ReadoutType Type, FieldStatus Status, string LanguageModule)
			: base(NodeId, FieldName, StringId, LocalizationSeed, Timepoint, Type, Status, LanguageModule)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringId">Corresponding String ID</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int StringId, string LocalizationSeed,
			DateTime Timepoint, long Value, ReadoutType Type, FieldStatus Status, string LanguageModule)
			: base(NodeId, FieldName, StringId, LocalizationSeed, Timepoint, Type, Status, LanguageModule)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <param name="Unit">Unit corresponding to the value.</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, string LocalizationSeed,
			DateTime Timepoint, double Value, int NrDecimals, string Unit, ReadoutType Type, FieldStatus Status, string LanguageModule)
			: base(NodeId, FieldName, StringIds, LocalizationSeed, Timepoint, Type, Status, LanguageModule)
		{
			this.unit = Unit;
			this.value = Value;
			this.nrDecimals = NrDecimals;
		}

		/// <summary>
		/// Numeric valued field.
		/// </summary>
		/// <param name="Node">Node</param>
		/// <param name="FieldName">Name of field</param>
		/// <param name="StringIds">Corresponding String IDs</param>
		/// <param name="LocalizationSeed">Localization seed, i.e. the default string for creating
		/// a localized field name.</param>
		/// <param name="Timepoint">Timepoint of field value.</param>
		/// <param name="Value">Value</param>
		/// <param name="Type">Type of value.</param>
		/// <param name="Status">Field status. Default value is <see cref="FieldStatus.AutomaticReadout"/>.</param>
		/// <param name="LanguageModule">Language Module to use for localization purposes. This parameter is optional. If
		/// not specified, or if empty or null, the language module of the metering library will be used.</param>
		public FieldNumeric(string NodeId, string FieldName, int[] StringIds, string LocalizationSeed,
			DateTime Timepoint, long Value, ReadoutType Type, FieldStatus Status, string LanguageModule)
			: base(NodeId, FieldName, StringIds, LocalizationSeed, Timepoint, Type, Status, LanguageModule)
		{
			this.unit = string.Empty;
			this.value = Value;
			this.nrDecimals = 0;
		}

		/// <summary>
		/// Field value.
		/// </summary>
		public double Value { get { return this.value; } set { this.value = value; } }

		/// <summary>
		/// Unit corresponding to the field value.
		/// </summary>
		public string Unit { get { return this.unit; } set { this.unit = value; } }

		/// <summary>
		/// Number of decimals to use.
		/// </summary>
		public int NrDecimals { get { return this.nrDecimals; } set { this.nrDecimals = value; } }

		/// <summary>
		/// String representation of the field value.
		/// </summary>
		/// <returns>String representation of the field value.</returns>
		public override string ToString()
		{
			return base.ToString() + "\t" +
				this.value.ToString("F" + this.nrDecimals.ToString()) +
				" " + this.unit + "\t(" + this.Type.ToString() + ")\t[" +
				this.Status.ToString() + "]";
		}

		/// <summary>
		/// Formats a numeric value.
		/// </summary>
		/// <param name="Value">Numeric value.</param>
		/// <param name="Unit">Corresponding (possibly empty) unit.</param>
		/// <param name="NrDecimals">Number of decimals to use.</param>
		/// <returns>String representation.</returns>
		public static string Format(double Value, string Unit, int NrDecimals)
		{
			string s;

			s = Value.ToString("F" + NrDecimals.ToString());

			if (!string.IsNullOrEmpty(Unit))
				s += " " + Unit;

			return s;
		}

		/// <summary>
		/// <see cref="Field.GetValueString"/>
		/// </summary>
		public override string GetValueString()
		{
			return Format(this.value, this.unit, this.nrDecimals);	
		}

		/// <summary>
		/// <see cref="Field.GetValue"/>
		/// </summary>
		public override object GetValue()
		{
			return this.value;
		}

		/// <summary>
		/// <see cref="Field.Copy"/>
		/// </summary>
		public override Field Copy()
		{
			return new FieldNumeric(this.NodeId, this.FieldName, this.StringIDs, this.Timepoint, this.value, this.nrDecimals, this.unit, 
				this.Type, this.Status, this.LanguageModule);
		}

		/// <summary>
		/// <see cref="Field.TagName"/>
		/// </summary>
		protected override string TagName
		{
			get
			{
				return "Numeric";
			}
		}

		/// <summary>
		/// <see cref="Field.ExportContent"/>
		/// </summary>
		protected override void ExportContent(System.Xml.XmlWriter w)
		{
			w.WriteAttributeString("value", XmlUtilities.DoubleToString(this.value, this.nrDecimals));
			w.WriteAttributeString("unit", this.unit);
		}

		/// <summary>
		/// <see cref="Field.Equals"/>
		/// </summary>
		public override bool Equals(object obj)
		{
			FieldNumeric F = obj as FieldNumeric;
			if (F == null)
				return false;

			if (this.value != F.value || this.unit != F.unit || this.nrDecimals != F.nrDecimals)
				return false;

			return base.Equals(obj);
		}

		/// <summary>
		/// <see cref="Object.GetHashCode()"/>
		/// </summary>
		public override int GetHashCode()
		{
			return base.GetHashCode() ^ 
				this.value.GetHashCode() ^
				this.unit.GetHashCode() ^
				this.nrDecimals.GetHashCode();
		}

        /// <summary>
        /// <see cref="Field.ExportAsXmppSensorData"/>
        /// </summary>
        public override void ExportAsXmppSensorData(System.Xml.XmlWriter w)
        {
            w.WriteStartElement("numeric");

            this.ExportAsXmppSensorDataCommonAttributes(w);

            w.WriteAttributeString("value", XmlUtilities.DoubleToString(this.value, this.nrDecimals));
            w.WriteAttributeString("unit", this.unit);

            w.WriteEndElement();
        }

		/// <summary>
		/// <see cref="Field.ExportAsJsonSensorData"/>
		/// </summary>
		public override void ExportAsJsonSensorData(JsonWriter w)
		{
			w.BeginObject ();

			w.WriteName ("fieldType");
			w.WriteValue ("numeric");

			this.ExportAsJsonSensorDataCommonAttributes(w);

			w.WriteName ("value");
			w.WriteValue (this.value);

			w.WriteName ("unit");
			w.WriteValue (this.unit);

			w.WriteName ("nrDec");
			w.WriteValue (this.nrDecimals);

			w.EndObject ();
		}

		/// <summary>
		/// <see cref="Field.ExportAsTurtleSensorData"/>
		/// </summary>
		public override void ExportAsTurtleSensorData(TurtleWriter w)
		{
			w.WritePredicateUri ("cl", "field");
			w.StartBlankNode ();

			this.ExportAsTurtleSensorDataCommonAttributes (w);

			w.WritePredicateUri ("cl", "numeric");
			w.WriteObjectLiteralTyped (this.value);

			//string EncodedUnit = HttpUtilities.UrlEncode (this.unit);
			//
			//if (EncodedUnit == this.unit)
			//	w.WriteObjectLiteralTyped (XmlUtilities.DoubleToString (this.value, this.nrDecimals), "clu", this.unit);
			//else
			//	w.WriteObjectLiteralTyped (XmlUtilities.DoubleToString (this.value, this.nrDecimals), "http://clayster.com/sw/u/" + EncodedUnit);

			w.WritePredicateUri ("cl", "unit");
			w.WriteObjectLiteral (this.unit);

			w.WritePredicateUri ("cl", "nrDec");
			w.WriteObjectLiteralTyped (this.nrDecimals);

			w.EndBlankNode ();
		}

	}
}
