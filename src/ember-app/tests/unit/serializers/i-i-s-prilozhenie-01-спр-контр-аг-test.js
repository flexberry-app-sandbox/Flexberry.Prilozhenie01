import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-prilozhenie-01-спр-контр-аг', 'Unit | Serializer | i-i-s-prilozhenie-01-спр-контр-аг', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-prilozhenie-01-спр-контр-аг',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'model:i-i-s-prilozhenie-01-док-план-за-на-д',
    'model:i-i-s-prilozhenie-01-спр-виды-раб',
    'model:i-i-s-prilozhenie-01-спр-ед-измер',
    'model:i-i-s-prilozhenie-01-спр-контр-аг',
    'model:i-i-s-prilozhenie-01-спр-номен',
    'model:i-i-s-prilozhenie-01-спр-объект-стр',
    'model:i-i-s-prilozhenie-01-спр-пользов',
    'model:i-i-s-prilozhenie-01-спр-тип-транс-ср',
    'model:i-i-s-prilozhenie-01-спр-трансп-ср',
    'model:i-i-s-prilozhenie-01-т-ч-пл-з-на-д',
    'model:i-i-s-prilozhenie-01-т-ч-факт-вып-р',
    'model:i-i-s-prilozhenie-01-факт-выпол-раб',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
