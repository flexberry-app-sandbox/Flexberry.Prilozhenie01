import {
  defineNamespace,
  defineProjections,
  Model as ТЧФактВыпРMixin
} from '../mixins/regenerated/models/i-i-s-prilozhenie-01-т-ч-факт-вып-р';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ТЧФактВыпРMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
