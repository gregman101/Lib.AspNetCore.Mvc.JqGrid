﻿using System;
using System.Collections.Generic;
using Lib.AspNetCore.Mvc.JqGrid.Infrastructure.Enums;
using Lib.AspNetCore.Mvc.JqGrid.Infrastructure.Options.ColumnModel;
using Lib.AspNetCore.Mvc.JqGrid.Infrastructure.Constants;

namespace Lib.AspNetCore.Mvc.JqGrid.Infrastructure.Options
{
    /// <summary>
    /// jqGrid options
    /// </summary>
    public class JqGridOptions
    {
        #region Fields
        private readonly IList<JqGridColumnModel> _columnsModels = new List<JqGridColumnModel>();
        private readonly IList<string> _columnsNames = new List<string>();
        #endregion

        #region Properties
        /// <summary>
        /// Gets the grid identifier which will be used for table (id='{0}'), pager div (id='{0}Pager') and in JavaScript.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the caption for the grid.
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// Gets the list of columns parameters descriptions.
        /// </summary>
        public IReadOnlyList<JqGridColumnModel> ColumnsModels { get { return (IReadOnlyList<JqGridColumnModel>)_columnsModels; } }

        /// <summary>
        /// Gets the list of columns names.
        /// </summary>
        public IReadOnlyList<string> ColumnsNames { get { return (IReadOnlyList<string>)_columnsNames; } }

        /// <summary>
        /// Gets or sets the string of data which will be used when DataType is set to JqGridDataTypes.XmlString or JqGridDataTypes.JsonString (default null).
        /// </summary>
        public string DataString { get; set; }

        /// <summary>
        /// Gets or sets the type of information to expect to represent data in the grid (default JqGridDataTypes.Xml).
        /// </summary>
        public JqGridDataTypes DataType { get; set; }

        /// <summary>
        /// Gets or sets the value indicating if the footer table (with one row) will be placed below the grid records and above the pager. The number of columns equal of these from ColumnsModels.
        /// </summary>
        public bool FooterEnabled { get; set; }

        /// <summary>
        /// Gets or sets the height of the grid in pixels (default '100%').
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the type of request to make (default JqGridMethodTypes.Get).
        /// </summary>
        public JqGridMethodTypes MethodType { get; set; }

        /// <summary>
        /// Gets or sets if grid should use a pager bar to navigate through the records (default: false).
        /// </summary>
        public bool Pager { get; set; }

        /// <summary>
        /// Gets or sets an array to construct a select box element in the pager in which user can change the number of the visible rows.
        /// </summary>
        public IList<int> RowsList { get; set; }

        /// <summary>
        /// Gets or sets how many records should be displayed in the grid (default 20).
        /// </summary>
        public int RowsNumber { get; set; }

        /// <summary>
        /// Gets or sets the initial sorting column index, when  using data returned from server
        /// </summary>
        public string SortingName { get; set; }

        /// <summary>
        /// Gets or sets the initial sorting order, when  using data returned from server (default JqGridSortingOrders.Asc)
        /// </summary>
        public JqGridSortingOrders SortingOrder { get; set; }

        /// <summary>
        /// Gets or sets the url for data requests
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the value indicating if the values from user data should be placed on footer.
        /// </summary>
        public bool UserDataOnFooter { get; set; }

        /// <summary>
        /// Gets or sets if grid should display the beginning and ending record number out of the total number of records in the query (default: false)
        /// </summary>
        public bool ViewRecords { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the JqGridOptions class.
        /// </summary>
        /// <param name="id">Identifier, which will be used for table (id='{0}'), pager div (id='{0}Pager'), filter grid div (id='{0}Search') and in JavaScript.</param>
        public JqGridOptions(string id)
        {
            Id = id;
            Caption = null;
            DataString = null;
            DataType = JqGridOptionsDefaults.DataType;
            FooterEnabled = JqGridOptionsDefaults.FooterEnabled;
            Height = null;
            MethodType = JqGridOptionsDefaults.MethodType;
            Pager = JqGridOptionsDefaults.Pager;
            RowsList = null;
            RowsNumber = JqGridOptionsDefaults.RowsNumber;
            SortingName = null;
            SortingOrder = JqGridOptionsDefaults.SortingOrder;
            Url = null;
            UserDataOnFooter = JqGridOptionsDefaults.UserDataOnFooter;
            ViewRecords = JqGridOptionsDefaults.ViewRecords;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Adds column to options.
        /// </summary>
        /// <param name="columnName">The column name.</param>
        /// <param name="columnModel">The column model.</param>
        /// <exception cref="System.ArgumentNullException">
        /// The column name or model haven't been provided. 
        /// </exception>
        public void AddColumn(string columnName, JqGridColumnModel columnModel)
        {
            if (String.IsNullOrWhiteSpace(columnName))
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            if (columnModel == null)
            {
                throw new ArgumentNullException(nameof(columnModel));
            }

            _columnsModels.Add(columnModel);
            _columnsNames.Add(columnName);
        }
        #endregion
    }
}
