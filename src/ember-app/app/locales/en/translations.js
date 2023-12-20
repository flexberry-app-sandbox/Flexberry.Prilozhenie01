import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/en/translations';

import IISPrilozhenie_01ДокПланЗаНаДLForm from './forms/i-i-s-prilozhenie-01-док-план-за-на-д-l';
import IISPrilozhenie_01СпрВидыРабLForm from './forms/i-i-s-prilozhenie-01-спр-виды-раб-l';
import IISPrilozhenie_01СпрЕдИзмерLForm from './forms/i-i-s-prilozhenie-01-спр-ед-измер-l';
import IISPrilozhenie_01СпрКонтрАгLForm from './forms/i-i-s-prilozhenie-01-спр-контр-аг-l';
import IISPrilozhenie_01СпрНоменLForm from './forms/i-i-s-prilozhenie-01-спр-номен-l';
import IISPrilozhenie_01СпрОбъектСтрLForm from './forms/i-i-s-prilozhenie-01-спр-объект-стр-l';
import IISPrilozhenie_01СпрПользовLForm from './forms/i-i-s-prilozhenie-01-спр-пользов-l';
import IISPrilozhenie_01СпрТипТрансСрLForm from './forms/i-i-s-prilozhenie-01-спр-тип-транс-ср-l';
import IISPrilozhenie_01СпрТранспСрLForm from './forms/i-i-s-prilozhenie-01-спр-трансп-ср-l';
import IISPrilozhenie_01ФактВыполРабLForm from './forms/i-i-s-prilozhenie-01-факт-выпол-раб-l';
import IISPrilozhenie_01ДокПланЗаНаДEForm from './forms/i-i-s-prilozhenie-01-док-план-за-на-д-e';
import IISPrilozhenie_01СпрВидыРабEForm from './forms/i-i-s-prilozhenie-01-спр-виды-раб-e';
import IISPrilozhenie_01СпрЕдИзмерEForm from './forms/i-i-s-prilozhenie-01-спр-ед-измер-e';
import IISPrilozhenie_01СпрКонтрАгEForm from './forms/i-i-s-prilozhenie-01-спр-контр-аг-e';
import IISPrilozhenie_01СпрНоменEForm from './forms/i-i-s-prilozhenie-01-спр-номен-e';
import IISPrilozhenie_01СпрОбъектСтрEForm from './forms/i-i-s-prilozhenie-01-спр-объект-стр-e';
import IISPrilozhenie_01СпрПользовEForm from './forms/i-i-s-prilozhenie-01-спр-пользов-e';
import IISPrilozhenie_01СпрТипТрансСрEForm from './forms/i-i-s-prilozhenie-01-спр-тип-транс-ср-e';
import IISPrilozhenie_01СпрТранспСрEForm from './forms/i-i-s-prilozhenie-01-спр-трансп-ср-e';
import IISPrilozhenie_01ФактВыполРабEForm from './forms/i-i-s-prilozhenie-01-факт-выпол-раб-e';
import IISPrilozhenie_01ДокПланЗаНаДModel from './models/i-i-s-prilozhenie-01-док-план-за-на-д';
import IISPrilozhenie_01СпрВидыРабModel from './models/i-i-s-prilozhenie-01-спр-виды-раб';
import IISPrilozhenie_01СпрЕдИзмерModel from './models/i-i-s-prilozhenie-01-спр-ед-измер';
import IISPrilozhenie_01СпрКонтрАгModel from './models/i-i-s-prilozhenie-01-спр-контр-аг';
import IISPrilozhenie_01СпрНоменModel from './models/i-i-s-prilozhenie-01-спр-номен';
import IISPrilozhenie_01СпрОбъектСтрModel from './models/i-i-s-prilozhenie-01-спр-объект-стр';
import IISPrilozhenie_01СпрПользовModel from './models/i-i-s-prilozhenie-01-спр-пользов';
import IISPrilozhenie_01СпрТипТрансСрModel from './models/i-i-s-prilozhenie-01-спр-тип-транс-ср';
import IISPrilozhenie_01СпрТранспСрModel from './models/i-i-s-prilozhenie-01-спр-трансп-ср';
import IISPrilozhenie_01ТЧПлЗНаДModel from './models/i-i-s-prilozhenie-01-т-ч-пл-з-на-д';
import IISPrilozhenie_01ТЧФактВыпРModel from './models/i-i-s-prilozhenie-01-т-ч-факт-вып-р';
import IISPrilozhenie_01ФактВыполРабModel from './models/i-i-s-prilozhenie-01-факт-выпол-раб';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-prilozhenie-01-док-план-за-на-д': IISPrilozhenie_01ДокПланЗаНаДModel,
    'i-i-s-prilozhenie-01-спр-виды-раб': IISPrilozhenie_01СпрВидыРабModel,
    'i-i-s-prilozhenie-01-спр-ед-измер': IISPrilozhenie_01СпрЕдИзмерModel,
    'i-i-s-prilozhenie-01-спр-контр-аг': IISPrilozhenie_01СпрКонтрАгModel,
    'i-i-s-prilozhenie-01-спр-номен': IISPrilozhenie_01СпрНоменModel,
    'i-i-s-prilozhenie-01-спр-объект-стр': IISPrilozhenie_01СпрОбъектСтрModel,
    'i-i-s-prilozhenie-01-спр-пользов': IISPrilozhenie_01СпрПользовModel,
    'i-i-s-prilozhenie-01-спр-тип-транс-ср': IISPrilozhenie_01СпрТипТрансСрModel,
    'i-i-s-prilozhenie-01-спр-трансп-ср': IISPrilozhenie_01СпрТранспСрModel,
    'i-i-s-prilozhenie-01-т-ч-пл-з-на-д': IISPrilozhenie_01ТЧПлЗНаДModel,
    'i-i-s-prilozhenie-01-т-ч-факт-вып-р': IISPrilozhenie_01ТЧФактВыпРModel,
    'i-i-s-prilozhenie-01-факт-выпол-раб': IISPrilozhenie_01ФактВыполРабModel
  },

  'application-name': 'Prilozhenie_3',

  forms: {
    loading: {
      'spinner-caption': 'Loading stuff, please wait for a moment...'
    },
    index: {
      greeting: 'Welcome to ember-flexberry test stand!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Menu'
          },
          'user-settings-service-checkbox': {
            caption: 'Use service to save user settings'
          },
          'show-menu': {
            caption: 'Show menu'
          },
          'hide-menu': {
            caption: 'Hide menu'
          },
          'language-dropdown': {
            caption: 'Application language',
            placeholder: 'Choose language'
          }
        },
        login: {
          caption: 'Login'
        },
        logout: {
          caption: 'Logout'
        }
      },

      footer: {
        'application-name': 'Prilozhenie_3',
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Prilozhenie_3',
          title: 'Prilozhenie_3'
        },
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        },
        index: {
          caption: 'Home',
          title: ''
        },
        'диспетчеризация-транспортных-средств': {
          caption: 'Диспетчеризация транспортных средств',
          title: 'Диспетчеризация транспортных средств',
          'i-i-s-prilozhenie-01-док-план-за-на-д-l': {
            caption: 'Документ плановая заявка на день',
            title: ''
          },
          'i-i-s-prilozhenie-01-спр-тип-транс-ср-l': {
            caption: 'Справочник тип транспортного средства',
            title: ''
          },
          'i-i-s-prilozhenie-01-спр-трансп-ср-l': {
            caption: 'Справочник транспортное средство',
            title: ''
          },
          'i-i-s-prilozhenie-01-спр-номен-l': {
            caption: 'Справочник номенклатура',
            title: ''
          },
          'i-i-s-prilozhenie-01-спр-контр-аг-l': {
            caption: 'Справочник контрагенты',
            title: ''
          },
          'i-i-s-prilozhenie-01-спр-ед-измер-l': {
            caption: 'Справочник единицы измерения',
            title: ''
          },
          'i-i-s-prilozhenie-01-спр-виды-раб-l': {
            caption: 'Справочник виды работ',
            title: ''
          },
          'i-i-s-prilozhenie-01-спр-объект-стр-l': {
            caption: 'Справочник объект строительства',
            title: ''
          },
          'i-i-s-prilozhenie-01-спр-пользов-l': {
            caption: 'Справочник пользователи',
            title: ''
          },
          'i-i-s-prilozhenie-01-факт-выпол-раб-l': {
            caption: 'Документ фактическое выполнение работ',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Save operation succeed',
      'save-success-message': 'Object saved',
      'save-error-message-caption': 'Save operation failed',
      'delete-success-message-caption': 'Delete operation succeed',
      'delete-success-message': 'Object deleted',
      'delete-error-message-caption': 'Delete operation failed'
    },
    'i-i-s-prilozhenie-01-док-план-за-на-д-l': IISPrilozhenie_01ДокПланЗаНаДLForm,
    'i-i-s-prilozhenie-01-спр-виды-раб-l': IISPrilozhenie_01СпрВидыРабLForm,
    'i-i-s-prilozhenie-01-спр-ед-измер-l': IISPrilozhenie_01СпрЕдИзмерLForm,
    'i-i-s-prilozhenie-01-спр-контр-аг-l': IISPrilozhenie_01СпрКонтрАгLForm,
    'i-i-s-prilozhenie-01-спр-номен-l': IISPrilozhenie_01СпрНоменLForm,
    'i-i-s-prilozhenie-01-спр-объект-стр-l': IISPrilozhenie_01СпрОбъектСтрLForm,
    'i-i-s-prilozhenie-01-спр-пользов-l': IISPrilozhenie_01СпрПользовLForm,
    'i-i-s-prilozhenie-01-спр-тип-транс-ср-l': IISPrilozhenie_01СпрТипТрансСрLForm,
    'i-i-s-prilozhenie-01-спр-трансп-ср-l': IISPrilozhenie_01СпрТранспСрLForm,
    'i-i-s-prilozhenie-01-факт-выпол-раб-l': IISPrilozhenie_01ФактВыполРабLForm,
    'i-i-s-prilozhenie-01-док-план-за-на-д-e': IISPrilozhenie_01ДокПланЗаНаДEForm,
    'i-i-s-prilozhenie-01-спр-виды-раб-e': IISPrilozhenie_01СпрВидыРабEForm,
    'i-i-s-prilozhenie-01-спр-ед-измер-e': IISPrilozhenie_01СпрЕдИзмерEForm,
    'i-i-s-prilozhenie-01-спр-контр-аг-e': IISPrilozhenie_01СпрКонтрАгEForm,
    'i-i-s-prilozhenie-01-спр-номен-e': IISPrilozhenie_01СпрНоменEForm,
    'i-i-s-prilozhenie-01-спр-объект-стр-e': IISPrilozhenie_01СпрОбъектСтрEForm,
    'i-i-s-prilozhenie-01-спр-пользов-e': IISPrilozhenie_01СпрПользовEForm,
    'i-i-s-prilozhenie-01-спр-тип-транс-ср-e': IISPrilozhenie_01СпрТипТрансСрEForm,
    'i-i-s-prilozhenie-01-спр-трансп-ср-e': IISPrilozhenie_01СпрТранспСрEForm,
    'i-i-s-prilozhenie-01-факт-выпол-раб-e': IISPrilozhenie_01ФактВыполРабEForm
  },

});

export default translations;
