﻿using Lib.AspNetCore.Mvc.JqGrid.Infrastructure.Enums;

namespace Lib.AspNetCore.Mvc.JqGrid.Infrastructure.Searching
{
    /// <summary>
    /// Class which represents filter in request from jqGrid.
    /// </summary>
    public class JqGridSearchingFilter
    {
        #region Properties
        /// <summary>
        /// Gets the searching column name.
        /// </summary>
        public string SearchingName { get; set; }

        /// <summary>
        /// Gets the searching value.
        /// </summary>
        public string SearchingValue { get; set; }

        /// <summary>
        /// Gets the searching operator.
        /// </summary>
        public JqGridSearchOperators SearchingOperator { get; set; }
        #endregion
    }
}
