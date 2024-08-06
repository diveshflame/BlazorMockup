// window.triggerDateInputClick = (elementId) => {
//     const dateInput = document.getElementById(elementId);
//     if (dateInput) {
//         dateInput.click();
//     } else {
//         console.error("Date input element not found");
//     }
// };


window.openDatePicker = (dateInput) => {
    console.log("openDatePicker called");
    console.log(dateInput);
    dateInput.focus();
    dateInput.click();
};

// window.openDatePicker = () => {
//     console.log("openDatePicker called");
//     const dateInput = document.getElementById("date-input");
//     if (dateInput) {
//         dateInput.click()
//         {
//             document.getElementById("date-input").classList.remove("hidden");
//             document.getElementById("date-input").classList.add("block");
//         };
//     } else {
//         console.error("Date input element not found");
//     }
// };