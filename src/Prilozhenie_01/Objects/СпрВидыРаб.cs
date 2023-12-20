﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Prilozhenie_01
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Спр виды раб.
    /// </summary>
    // *** Start programmer edit section *** (СпрВидыРаб CustomAttributes)

    // *** End programmer edit section *** (СпрВидыРаб CustomAttributes)
    [AutoAltered()]
    [Caption("Справочник виды работ")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СпрВидыРабE", new string[] {
            "Код as \'Код\'",
            "Наименование as \'Наименование\'",
            "СпрЕдИзмер as \'Спр ед измер\'",
            "СпрЕдИзмер.Наименование as \'Наименование\'",
            "СпрТипТрансСр as \'Спр тип транс ср\'",
            "СпрТипТрансСр.Описание as \'Описание\'"}, Hidden=new string[] {
            "СпрЕдИзмер.Наименование",
            "СпрТипТрансСр.Описание"})]
    [MasterViewDefineAttribute("СпрВидыРабE", "СпрЕдИзмер", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [MasterViewDefineAttribute("СпрВидыРабE", "СпрТипТрансСр", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Описание")]
    [View("СпрВидыРабL", new string[] {
            "Код as \'Код\'",
            "Наименование as \'Наименование\'",
            "СпрЕдИзмер.Наименование as \'Наименование\'",
            "СпрТипТрансСр.Описание as \'Описание\'"})]
    [View("СпрВидыРаботE", new string[] {
            "Код as \'Код\'",
            "Наименование as \'Наименование\'",
            "СпрЕдИзмер as \'Единицы измерения\'",
            "СпрЕдИзмер.Наименование as \'Единицы измерения\'",
            "СпрТипТрансСр as \'Тип транспортного средства\'",
            "СпрТипТрансСр.Наименование as \'Тип транспортного средства\'"})]
    [View("СпрВидыРаботL", new string[] {
            "Код as \'Код\'",
            "Наименование as \'Наименование\'",
            "СпрЕдИзмер.Наименование as \'Единицы измерения\'",
            "СпрТипТрансСр.Наименование as \'Тип транспортного средства\'"})]
    public class СпрВидыРаб : ICSSoft.STORMNET.DataObject
    {
        
        private int fКод;
        
        private string fНаименование;
        
        private IIS.Prilozhenie_01.СпрТипТрансСр fСпрТипТрансСр;
        
        private IIS.Prilozhenie_01.СпрЕдИзмер fСпрЕдИзмер;
        
        // *** Start programmer edit section *** (СпрВидыРаб CustomMembers)

        // *** End programmer edit section *** (СпрВидыРаб CustomMembers)

        
        /// <summary>
        /// Код.
        /// </summary>
        // *** Start programmer edit section *** (СпрВидыРаб.Код CustomAttributes)

        // *** End programmer edit section *** (СпрВидыРаб.Код CustomAttributes)
        public virtual int Код
        {
            get
            {
                // *** Start programmer edit section *** (СпрВидыРаб.Код Get start)

                // *** End programmer edit section *** (СпрВидыРаб.Код Get start)
                int result = this.fКод;
                // *** Start programmer edit section *** (СпрВидыРаб.Код Get end)

                // *** End programmer edit section *** (СпрВидыРаб.Код Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрВидыРаб.Код Set start)

                // *** End programmer edit section *** (СпрВидыРаб.Код Set start)
                this.fКод = value;
                // *** Start programmer edit section *** (СпрВидыРаб.Код Set end)

                // *** End programmer edit section *** (СпрВидыРаб.Код Set end)
            }
        }
        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (СпрВидыРаб.Наименование CustomAttributes)

        // *** End programmer edit section *** (СпрВидыРаб.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (СпрВидыРаб.Наименование Get start)

                // *** End programmer edit section *** (СпрВидыРаб.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (СпрВидыРаб.Наименование Get end)

                // *** End programmer edit section *** (СпрВидыРаб.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрВидыРаб.Наименование Set start)

                // *** End programmer edit section *** (СпрВидыРаб.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (СпрВидыРаб.Наименование Set end)

                // *** End programmer edit section *** (СпрВидыРаб.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Спр виды раб.
        /// </summary>
        // *** Start programmer edit section *** (СпрВидыРаб.СпрЕдИзмер CustomAttributes)

        // *** End programmer edit section *** (СпрВидыРаб.СпрЕдИзмер CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрЕдИзмер"})]
        [NotNull()]
        public virtual IIS.Prilozhenie_01.СпрЕдИзмер СпрЕдИзмер
        {
            get
            {
                // *** Start programmer edit section *** (СпрВидыРаб.СпрЕдИзмер Get start)

                // *** End programmer edit section *** (СпрВидыРаб.СпрЕдИзмер Get start)
                IIS.Prilozhenie_01.СпрЕдИзмер result = this.fСпрЕдИзмер;
                // *** Start programmer edit section *** (СпрВидыРаб.СпрЕдИзмер Get end)

                // *** End programmer edit section *** (СпрВидыРаб.СпрЕдИзмер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрВидыРаб.СпрЕдИзмер Set start)

                // *** End programmer edit section *** (СпрВидыРаб.СпрЕдИзмер Set start)
                this.fСпрЕдИзмер = value;
                // *** Start programmer edit section *** (СпрВидыРаб.СпрЕдИзмер Set end)

                // *** End programmer edit section *** (СпрВидыРаб.СпрЕдИзмер Set end)
            }
        }
        
        /// <summary>
        /// Спр виды раб.
        /// </summary>
        // *** Start programmer edit section *** (СпрВидыРаб.СпрТипТрансСр CustomAttributes)

        // *** End programmer edit section *** (СпрВидыРаб.СпрТипТрансСр CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрТипТрансСр"})]
        [NotNull()]
        public virtual IIS.Prilozhenie_01.СпрТипТрансСр СпрТипТрансСр
        {
            get
            {
                // *** Start programmer edit section *** (СпрВидыРаб.СпрТипТрансСр Get start)

                // *** End programmer edit section *** (СпрВидыРаб.СпрТипТрансСр Get start)
                IIS.Prilozhenie_01.СпрТипТрансСр result = this.fСпрТипТрансСр;
                // *** Start programmer edit section *** (СпрВидыРаб.СпрТипТрансСр Get end)

                // *** End programmer edit section *** (СпрВидыРаб.СпрТипТрансСр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (СпрВидыРаб.СпрТипТрансСр Set start)

                // *** End programmer edit section *** (СпрВидыРаб.СпрТипТрансСр Set start)
                this.fСпрТипТрансСр = value;
                // *** Start programmer edit section *** (СпрВидыРаб.СпрТипТрансСр Set end)

                // *** End programmer edit section *** (СпрВидыРаб.СпрТипТрансСр Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СпрВидыРабE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СпрВидыРабE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СпрВидыРабE", typeof(IIS.Prilozhenie_01.СпрВидыРаб));
                }
            }
            
            /// <summary>
            /// "СпрВидыРабL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СпрВидыРабL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СпрВидыРабL", typeof(IIS.Prilozhenie_01.СпрВидыРаб));
                }
            }
            
            /// <summary>
            /// "СпрВидыРаботE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СпрВидыРаботE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СпрВидыРаботE", typeof(IIS.Prilozhenie_01.СпрВидыРаб));
                }
            }
            
            /// <summary>
            /// "СпрВидыРаботL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СпрВидыРаботL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СпрВидыРаботL", typeof(IIS.Prilozhenie_01.СпрВидыРаб));
                }
            }
        }
    }
}
