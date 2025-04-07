
window.onload = function () {
    const rows = document.querySelectorAll("#studentTable tbody tr");

    rows.forEach(row => {
        const nameCell = row.cells[1];
        if (nameCell) {
            const name = nameCell.textContent.trim();
            if (name.charAt(0).toLowerCase() === 'm') {
                row.style.color = "red";
            }
        }
    });
};
    
function Delete(id) {

    fetch(`/Student/Delete/${id}`)
        .then(response => response.json())
        .then(data => {
            if (data.success) {
                const item = document.getElementById("student");
                if (item) item.remove(); // remove from UI
            }
        })
        .catch(error => console.error("Delete failed:", error));
}