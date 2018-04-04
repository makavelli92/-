-- Функция предназначена для получения КОЛИЧЕСТВА ЛИНИЙ в графике (индикаторе) по выбранному идентификатору
getLinesCount(tag); -- Возвращает число
   -- tag - (STRING) идентификатор графика (индикатора), о котором писалось выше
 
-- Функция предназначена для получения информации о КОЛИЧЕСТВЕ СВЕЧЕЙ по выбранному идентификатору
getNumCandles(tag); -- Возвращает число
   -- tag - (STRING) идентификатор графика (индикатора), о котором писалось выше
 
-- Функция предназначена для получения информации о свечах по идентификатору (заказ данных для построения графика функция не осуществляет, поэтому для успешного доступа нужный график должен быть открыт)
t, n, l = getCandlesByIndex (tag, line, first_candle, count);
   -- Параметры:
      -- tag          – (STRING) строковый идентификатор графика или индикатора 
      -- line         – (NUMBER) номер линии графика или индикатора. Первая линия имеет номер 0 
      -- first_candle – (NUMBER) индекс первой свечи. !!! ПЕРВАЯ (САМАЯ ЛЕВАЯ) СВЕЧКА ИМЕЕТ ИНДЕКС 0 !!!
      -- count        – (NUMBER) количество запрашиваемых свечей
   -- Возвращаемые значения:
      -- t – таблица, содержащая запрашиваемые свечи, пример работы: 
         local O = t[i].open; -- Получить значение Open для указанной свечи (цена открытия свечи)
         local H = t[i].high; -- Получить значение High для указанной свечи (наибольшая цена свечи)
         local L = t[i].low; -- Получить значение Low для указанной свечи (наименьшая цена свечи)
         local C = t[i].close; -- Получить значение Close для указанной свечи (цена закрытия свечи)
         local V = t[i].volume; -- Получить значение Volume для указанной свечи (объем сделок в свече)
         local T = t[i].datetime; -- Получить значение datetime для указанной свечи
            -- Где i - индекс свечи от 0 до n-1
      -- n – количество свечей в таблице t
      -- l – легенда (подпись) графика