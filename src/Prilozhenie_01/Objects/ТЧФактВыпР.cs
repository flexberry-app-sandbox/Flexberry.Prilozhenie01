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
    /// ТЧФактВыпР.
    /// </summary>
    // *** Start programmer edit section *** (ТЧФактВыпР CustomAttributes)

    // *** End programmer edit section *** (ТЧФактВыпР CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ТЧФактВыпРE", new string[] {
            "СтатЗатр as \'Статья затрат\'",
            "СпрНомен as \'Номенклатура\'",
            "СпрНомен.Наименование as \'Номенклатура\'",
            "СпрКонтрАг as \'Контрагент\'",
            "СпрКонтрАг.Наименование as \'Контрагент\'",
            "СпрВидыРаб as \'Виды работ\'",
            "СпрВидыРаб.Наименование as \'Виды работ\'",
            "ОбРаб as \'Объем работы\'",
            "СпрТранспСр as \'Транспортные средства\'",
            "СпрТранспСр.Наименование as \'Транспортные средства\'",
            "СпрТипТрансСр",
            "СпрТипТрансСр.Наименование as \'Типы транспортного средства\'",
            "ВрПриб as \'Время прибытия\'",
            "ВрУб as \'Время убытия\'",
            "КлЧасНОб as \'Количество часов на объекте\'",
            "КдПрост as \'Код простоя\'",
            "КолЧасПр as \'Количество часов простоя\'",
            "КолЧасРаб as \'Количество часов работы\'",
            "ОбГруз as \'Объем груза\'",
            "СпрЕдИзмер as \'Единицы измерения\'",
            "СпрЕдИзмер.Наименование as \'Единицы измерения\'"})]
    [MasterViewDefineAttribute("ТЧФактВыпРE", "СпрНомен", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Номенклатура")]
    [MasterViewDefineAttribute("ТЧФактВыпРE", "СпрКонтрАг", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Контрагент")]
    [MasterViewDefineAttribute("ТЧФактВыпРE", "СпрВидыРаб", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Виды работ")]
    [MasterViewDefineAttribute("ТЧФактВыпРE", "СпрТранспСр", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Транспортные средства")]
    [MasterViewDefineAttribute("ТЧФактВыпРE", "СпрТипТрансСр", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Типы транспортного средства")]
    [MasterViewDefineAttribute("ТЧФактВыпРE", "СпрЕдИзмер", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Единицы измерения")]
    public class ТЧФактВыпР : ICSSoft.STORMNET.DataObject
    {
        
        private string fСтатЗатр;
        
        private string fОбРаб;
        
        private string fВрПриб;
        
        private string fВрУб;
        
        private float fКлЧасНОб;
        
        private float fОбГруз;
        
        private float fКдПрост;
        
        private float fКолЧасПр;
        
        private float fКолЧасРаб;
        
        private IIS.Prilozhenie_01.СпрЕдИзмер fСпрЕдИзмер;
        
        private IIS.Prilozhenie_01.СпрТранспСр fСпрТранспСр;
        
        private IIS.Prilozhenie_01.СпрНомен fСпрНомен;
        
        private IIS.Prilozhenie_01.СпрТипТрансСр fСпрТипТрансСр;
        
        private IIS.Prilozhenie_01.СпрВидыРаб fСпрВидыРаб;
        
        private IIS.Prilozhenie_01.СпрКонтрАг fСпрКонтрАг;
        
        private IIS.Prilozhenie_01.ФактВыполРаб fФактВыполРаб;
        
        // *** Start programmer edit section *** (ТЧФактВыпР CustomMembers)

        // *** End programmer edit section *** (ТЧФактВыпР CustomMembers)

        
        /// <summary>
        /// ВрПриб.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.ВрПриб CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.ВрПриб CustomAttributes)
        [StrLen(255)]
        public virtual string ВрПриб
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.ВрПриб Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.ВрПриб Get start)
                string result = this.fВрПриб;
                // *** Start programmer edit section *** (ТЧФактВыпР.ВрПриб Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.ВрПриб Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.ВрПриб Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.ВрПриб Set start)
                this.fВрПриб = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.ВрПриб Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.ВрПриб Set end)
            }
        }
        
        /// <summary>
        /// ВрУб.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.ВрУб CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.ВрУб CustomAttributes)
        [StrLen(255)]
        public virtual string ВрУб
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.ВрУб Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.ВрУб Get start)
                string result = this.fВрУб;
                // *** Start programmer edit section *** (ТЧФактВыпР.ВрУб Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.ВрУб Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.ВрУб Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.ВрУб Set start)
                this.fВрУб = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.ВрУб Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.ВрУб Set end)
            }
        }
        
        /// <summary>
        /// КдПрост.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.КдПрост CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.КдПрост CustomAttributes)
        public virtual float КдПрост
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.КдПрост Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.КдПрост Get start)
                float result = this.fКдПрост;
                // *** Start programmer edit section *** (ТЧФактВыпР.КдПрост Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.КдПрост Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.КдПрост Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.КдПрост Set start)
                this.fКдПрост = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.КдПрост Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.КдПрост Set end)
            }
        }
        
        /// <summary>
        /// КлЧасНОб.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.КлЧасНОб CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.КлЧасНОб CustomAttributes)
        public virtual float КлЧасНОб
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.КлЧасНОб Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.КлЧасНОб Get start)
                float result = this.fКлЧасНОб;
                // *** Start programmer edit section *** (ТЧФактВыпР.КлЧасНОб Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.КлЧасНОб Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.КлЧасНОб Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.КлЧасНОб Set start)
                this.fКлЧасНОб = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.КлЧасНОб Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.КлЧасНОб Set end)
            }
        }
        
        /// <summary>
        /// КолЧасПр.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.КолЧасПр CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.КолЧасПр CustomAttributes)
        public virtual float КолЧасПр
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.КолЧасПр Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.КолЧасПр Get start)
                float result = this.fКолЧасПр;
                // *** Start programmer edit section *** (ТЧФактВыпР.КолЧасПр Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.КолЧасПр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.КолЧасПр Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.КолЧасПр Set start)
                this.fКолЧасПр = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.КолЧасПр Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.КолЧасПр Set end)
            }
        }
        
        /// <summary>
        /// КолЧасРаб.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.КолЧасРаб CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.КолЧасРаб CustomAttributes)
        public virtual float КолЧасРаб
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.КолЧасРаб Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.КолЧасРаб Get start)
                float result = this.fКолЧасРаб;
                // *** Start programmer edit section *** (ТЧФактВыпР.КолЧасРаб Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.КолЧасРаб Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.КолЧасРаб Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.КолЧасРаб Set start)
                this.fКолЧасРаб = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.КолЧасРаб Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.КолЧасРаб Set end)
            }
        }
        
        /// <summary>
        /// ОбГруз.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.ОбГруз CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.ОбГруз CustomAttributes)
        public virtual float ОбГруз
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.ОбГруз Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.ОбГруз Get start)
                float result = this.fОбГруз;
                // *** Start programmer edit section *** (ТЧФактВыпР.ОбГруз Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.ОбГруз Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.ОбГруз Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.ОбГруз Set start)
                this.fОбГруз = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.ОбГруз Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.ОбГруз Set end)
            }
        }
        
        /// <summary>
        /// ОбРаб.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.ОбРаб CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.ОбРаб CustomAttributes)
        [StrLen(255)]
        public virtual string ОбРаб
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.ОбРаб Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.ОбРаб Get start)
                string result = this.fОбРаб;
                // *** Start programmer edit section *** (ТЧФактВыпР.ОбРаб Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.ОбРаб Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.ОбРаб Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.ОбРаб Set start)
                this.fОбРаб = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.ОбРаб Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.ОбРаб Set end)
            }
        }
        
        /// <summary>
        /// СтатЗатр.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.СтатЗатр CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.СтатЗатр CustomAttributes)
        [StrLen(255)]
        public virtual string СтатЗатр
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СтатЗатр Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.СтатЗатр Get start)
                string result = this.fСтатЗатр;
                // *** Start programmer edit section *** (ТЧФактВыпР.СтатЗатр Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.СтатЗатр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СтатЗатр Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.СтатЗатр Set start)
                this.fСтатЗатр = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.СтатЗатр Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.СтатЗатр Set end)
            }
        }
        
        /// <summary>
        /// ТЧФактВыпР.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.СпрВидыРаб CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.СпрВидыРаб CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрВидыРаб"})]
        [NotNull()]
        public virtual IIS.Prilozhenie_01.СпрВидыРаб СпрВидыРаб
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрВидыРаб Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрВидыРаб Get start)
                IIS.Prilozhenie_01.СпрВидыРаб result = this.fСпрВидыРаб;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрВидыРаб Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрВидыРаб Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрВидыРаб Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрВидыРаб Set start)
                this.fСпрВидыРаб = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрВидыРаб Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрВидыРаб Set end)
            }
        }
        
        /// <summary>
        /// ТЧФактВыпР.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.СпрЕдИзмер CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.СпрЕдИзмер CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрЕдИзмер"})]
        [NotNull()]
        public virtual IIS.Prilozhenie_01.СпрЕдИзмер СпрЕдИзмер
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрЕдИзмер Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрЕдИзмер Get start)
                IIS.Prilozhenie_01.СпрЕдИзмер result = this.fСпрЕдИзмер;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрЕдИзмер Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрЕдИзмер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрЕдИзмер Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрЕдИзмер Set start)
                this.fСпрЕдИзмер = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрЕдИзмер Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрЕдИзмер Set end)
            }
        }
        
        /// <summary>
        /// ТЧФактВыпР.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.СпрКонтрАг CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.СпрКонтрАг CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрКонтрАг"})]
        [NotNull()]
        public virtual IIS.Prilozhenie_01.СпрКонтрАг СпрКонтрАг
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрКонтрАг Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрКонтрАг Get start)
                IIS.Prilozhenie_01.СпрКонтрАг result = this.fСпрКонтрАг;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрКонтрАг Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрКонтрАг Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрКонтрАг Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрКонтрАг Set start)
                this.fСпрКонтрАг = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрКонтрАг Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрКонтрАг Set end)
            }
        }
        
        /// <summary>
        /// ТЧФактВыпР.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.СпрНомен CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.СпрНомен CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрНомен"})]
        [NotNull()]
        public virtual IIS.Prilozhenie_01.СпрНомен СпрНомен
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрНомен Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрНомен Get start)
                IIS.Prilozhenie_01.СпрНомен result = this.fСпрНомен;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрНомен Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрНомен Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрНомен Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрНомен Set start)
                this.fСпрНомен = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрНомен Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрНомен Set end)
            }
        }
        
        /// <summary>
        /// ТЧФактВыпР.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.СпрТипТрансСр CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.СпрТипТрансСр CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрТипТрансСр"})]
        [NotNull()]
        public virtual IIS.Prilozhenie_01.СпрТипТрансСр СпрТипТрансСр
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрТипТрансСр Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрТипТрансСр Get start)
                IIS.Prilozhenie_01.СпрТипТрансСр result = this.fСпрТипТрансСр;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрТипТрансСр Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрТипТрансСр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрТипТрансСр Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрТипТрансСр Set start)
                this.fСпрТипТрансСр = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрТипТрансСр Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрТипТрансСр Set end)
            }
        }
        
        /// <summary>
        /// ТЧФактВыпР.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.СпрТранспСр CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.СпрТранспСр CustomAttributes)
        [PropertyStorage(new string[] {
                "СпрТранспСр"})]
        [NotNull()]
        public virtual IIS.Prilozhenie_01.СпрТранспСр СпрТранспСр
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрТранспСр Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрТранспСр Get start)
                IIS.Prilozhenie_01.СпрТранспСр result = this.fСпрТранспСр;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрТранспСр Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрТранспСр Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрТранспСр Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрТранспСр Set start)
                this.fСпрТранспСр = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.СпрТранспСр Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.СпрТранспСр Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Prilozhenie_01.ФактВыполРаб.
        /// </summary>
        // *** Start programmer edit section *** (ТЧФактВыпР.ФактВыполРаб CustomAttributes)

        // *** End programmer edit section *** (ТЧФактВыпР.ФактВыполРаб CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ФактВыполРаб"})]
        public virtual IIS.Prilozhenie_01.ФактВыполРаб ФактВыполРаб
        {
            get
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.ФактВыполРаб Get start)

                // *** End programmer edit section *** (ТЧФактВыпР.ФактВыполРаб Get start)
                IIS.Prilozhenie_01.ФактВыполРаб result = this.fФактВыполРаб;
                // *** Start programmer edit section *** (ТЧФактВыпР.ФактВыполРаб Get end)

                // *** End programmer edit section *** (ТЧФактВыпР.ФактВыполРаб Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТЧФактВыпР.ФактВыполРаб Set start)

                // *** End programmer edit section *** (ТЧФактВыпР.ФактВыполРаб Set start)
                this.fФактВыполРаб = value;
                // *** Start programmer edit section *** (ТЧФактВыпР.ФактВыполРаб Set end)

                // *** End programmer edit section *** (ТЧФактВыпР.ФактВыполРаб Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ТЧФактВыпРE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТЧФактВыпРE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТЧФактВыпРE", typeof(IIS.Prilozhenie_01.ТЧФактВыпР));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ТЧФактВыпР.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfТЧФактВыпР CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfТЧФактВыпР CustomAttributes)
    public class DetailArrayOfТЧФактВыпР : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Prilozhenie_01.DetailArrayOfТЧФактВыпР members)

        // *** End programmer edit section *** (IIS.Prilozhenie_01.DetailArrayOfТЧФактВыпР members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ТЧФактВыпР by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ТЧФактВыпР.
        /// </summary>
        public DetailArrayOfТЧФактВыпР(IIS.Prilozhenie_01.ФактВыполРаб fФактВыполРаб) : 
                base(typeof(ТЧФактВыпР), ((ICSSoft.STORMNET.DataObject)(fФактВыполРаб)))
        {
        }
        
        public IIS.Prilozhenie_01.ТЧФактВыпР this[int index]
        {
            get
            {
                return ((IIS.Prilozhenie_01.ТЧФактВыпР)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Prilozhenie_01.ТЧФактВыпР dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
