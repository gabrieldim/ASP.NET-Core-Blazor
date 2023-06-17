function createPieChart(revenueList) {
    const labels = revenueList.map(revenue => revenue.year);
    const data = revenueList.map(revenue => revenue.amount);

    new Chart(document.getElementById("pieChart"), {
        type: 'pie',
        data: {
            labels: labels,
            datasets: [{
                label: 'Revenue',
                data: data,
                backgroundColor: [
                    'rgba(255, 99, 132, 0.6)',
                    'rgba(54, 162, 235, 0.6)',
                    'rgba(255, 206, 86, 0.6)',
                ],
            }],
        },
    });
}
