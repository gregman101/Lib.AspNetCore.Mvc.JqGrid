﻿namespace Lib.AspNetCore.Mvc.JqGrid.Helper.Constants
{
    internal static class JqGridOptionsNames
    {
        internal const string COLUMNS_NAMES_FIELD = "colNames";
        internal const string COLUMNS_MODEL_FIELD = "colModel";

        internal static class ColumnModel
        {
            internal const string NAME_FIELD = "name";
            internal const string INDEX_FIELD = "index";
            internal const string INITIAL_SORTING_ORDER_FIELD = "firstsortorder";
            internal const string SORTABLE_FIELD = "sortable";
            internal const string SORT_TYPE_FIELD = "sorttype";
            internal const string FORMATTER_FIELD = "formatter";
            internal const string UNFORMATTER_FIELD = "unformat";
            internal const string FORMATTER_OPTIONS_FIELD = "formatoptions";

            internal static class Formatter
            {
                internal const string ADD_PARAM = "addParam";
                internal const string BASE_LINK_URL = "baseLinkUrl";
                internal const string DECIMAL_PLACES = "decimalPlaces";
                internal const string DECIMAL_SEPARATOR = "decimalSeparator";
                internal const string DEFAULT_VALUE = "defaultValue";
                internal const string DISABLED = "disabled";
                internal const string ID_NAME = "idName";
                internal const string OUTPUT_FORMAT = "newformat";
                internal const string PREFIX = "prefix";
                internal const string SHOW_ACTION = "showAction";
                internal const string SOURCE_FORMAT = "srcformat";
                internal const string SUFFIX = "suffix";
                internal const string TARGET = "target";
                internal const string THOUSANDS_SEPARATOR = "thousandsSeparator";
                internal const string EDIT_BUTTON = "editbutton";
                internal const string DELETE_BUTTON = "delbutton";
                internal const string USE_FORM_EDITING = "editformbutton";
                internal const string EDIT_OPTIONS = "editOptions";
                internal const string DELETE_OPTIONS = "delOptions";
            }
        };

        internal static class InlineNavigator
        {
            internal const string KEYS = "keys";
            internal const string ON_EDIT_FUNCTION = "onEdit";
            internal const string SUCCESS_FUNCTION = "onSuccess";
            internal const string URL = "url";
            internal const string AFTER_SAVE_FUNCTION = "afterSave";
            internal const string ERROR_FUNCTION = "onError";
            internal const string AFTER_RESTORE_FUNCTION = "afterRestore";
            internal const string RESTORE_AFTER_ERROR = "restoreAfterError";
            internal const string METHOD_TYPE = "mtype";
            internal const string EXTRA_PARAM = "extraparam";
        }

        internal static class Navigator
        {
            internal const string BEFORE_INIT_DATA = "beforeInitData";
            internal const string BEFORE_SHOW_FORM = "beforeShowForm";
            internal const string CLOSE_ON_ESCAPE = "closeOnEscape";
            internal const string DATA_HEIGHT = "dataheight";
            internal const string DATA_WIDTH = "datawidth";
            internal const string DRAGABLE = "drag";
            internal const string HEIGHT = "height";
            internal const string LEFT = "left";
            internal const string MODAL = "modal";
            internal const string ON_CLOSE = "onClose";
            internal const string OVERLAY = "overlay";
            internal const string RESIZE = "resize";
            internal const string TOP = "top";
            internal const string USE_JQ_MODAL = "jqModal";
        }
    }
}