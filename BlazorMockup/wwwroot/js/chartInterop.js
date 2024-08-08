window.createChart = (chartCanvas, chartType, labels, data, datasetLabel, legendPosition = 'top') => {
    console.log("Canvas element:", chartCanvas);
    const canvas = chartCanvas;
    const ctx = canvas.getContext('2d');
    console.log("Creating chart with data:", { chartType, labels, data, datasetLabel, legendPosition });
    window.myChart = new Chart(ctx, {
        type: chartType,
        data: {
            labels: labels,
            datasets: [{
                label: datasetLabel,
                data: data,
                backgroundColor: 'rgba(75, 192, 192, 0.2)',
                borderColor: 'rgba(75, 192, 192, 1)',
                borderWidth: 1,
                fill: false
            }]
        },
        options: {
            responsive: true,
            plugins: {
                legend: {
                    position: legendPosition,
                    display: true,
                    labels: {
                        font: {
                            size: 14
                        }
                    }
                },
                title: {
                    display: true,
                    text: `${datasetLabel} vs Age`,
                    font: {
                        size: 18
                    }
                }
            },
            scales: {
                x: {
                    title: {
                        display: true,
                        text: 'Age'
                    }
                },
                y: {
                    beginAtZero: true,
                    title: {
                        display: true,
                        text: datasetLabel
                    }
                }
            }
        }
    });
};

window.updateChart = (canvas, chartType, labels, data, datasetLabel, legendPosition = 'right') => {
    console.log("Updating chart with data:", { chartType, labels, data, datasetLabel, legendPosition });
    if (window.myChart) {
        window.myChart.data.labels = labels;
        window.myChart.data.datasets[0].data = data;
        window.myChart.data.datasets[0].label = datasetLabel;
        window.myChart.options.scales.y.title.text = datasetLabel;
        window.myChart.options.plugins.legend.position = legendPosition;
        window.myChart.options.plugins.title.text = `${datasetLabel} vs Age`;
        window.myChart.update();
    } else {
        createChart(canvas, chartType, labels, data, datasetLabel, legendPosition);
    }
};