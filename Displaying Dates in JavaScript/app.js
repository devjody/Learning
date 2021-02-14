const day = dayjs();
console.log(day);
console.log(day.format("D/M/YY"));
console.log(day.format("DD/MM/YYYY"));
console.log(day.format("ddd/MMMM/YY"));
console.log(day.format("HH:mm"));

function formateDate(dateObj) {
  const parts = {
    day: dateObj.getDate(),
    month: dateObj.getMonth() + 1,
    year: dateObj.getFullYear(),
  };
  return parts.day + "/" 
        +parts.month + "/" 
        +parts.year;
}
  
const myDate = new Date();
console.log(myDate);

const myDateFormatted = formateDate(myDate);
console.log(myDateFormatted);
