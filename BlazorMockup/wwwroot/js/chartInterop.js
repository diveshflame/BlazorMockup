window.createChart = (chartCanvas, chartType, labels, data,
                        LinePlusTwo, LinePlusOne, LineMinusOne, LineMinusTwo, 
                        datasetLabel, legendPosition = 'top') => {
    console.log("Canvas element:", chartCanvas);
    const canvas = chartCanvas;
    const ctx = canvas.getContext('2d');
    console.log("Creating chart with data:", { chartType, labels, data, datasetLabel, legendPosition });
    window.myChart = new Chart(ctx, {
        type: chartType,
        data: {
            labels: labels,
            datasets: [
                {
                    label: '+2 SD',
                    data: LinePlusTwo,
                    borderColor: 'rgba(255, 0, 0, 0.5)', // Red
                    borderWidth: 1,
                    fill: false
                },
                {
                    label: '+1 SD',
                    data: LinePlusOne,
                    borderColor: 'rgba(255, 0, 0, 0.5)', // Red
                    borderWidth: 1,
                    fill: false
                },
                {
                    label: '-1 SD',
                    data: LineMinusOne,
                    borderColor: 'rgba(0, 0, 255, 0.5)', // Blue
                    borderWidth: 1,
                    fill: false
                },
                {
                    label: '-2 SD',
                    data: LineMinusTwo,
                    backgroundColor: 'rgba(0, 0, 255, 0.5)', // Blue
                    borderColor: 'rgba(0, 0, 255, 0.5)', // Blue
                    borderWidth: 1,
                    fill: false
                },
                {
                label: datasetLabel,
                data: data,
                backgroundColor: 'rgba(75, 192, 192, 0.2)',
                borderColor: 'rgba(75, 192, 192, 1)',
                borderWidth: 1,
                fill: false
            }
        ]
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
                    text: `${datasetLabel} vs Month`,
                    font: {
                        size: 18
                    }
                }
            },
            scales: {
                x: {
                    title: {
                        display: true,
                        text: 'Month'
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

window.updateChart = (chartCanvas, chartType, labels, data,
                        LinePlusTwo, LinePlusOne, LineMinusOne, LineMinusTwo, 
                        datasetLabel, legendPosition = 'top') => {
    console.log("Updating chart with data:", { chartType, labels, data, datasetLabel, legendPosition });
    if (window.myChart) {
        window.myChart.data.labels = labels;
        window.myChart.data.datasets[0].data = LinePlusTwo;
        window.myChart.data.datasets[1].data = LinePlusOne;
        window.myChart.data.datasets[3].data = LineMinusOne;
        window.myChart.data.datasets[4].data =LineMinusTwo;
        window.myChart.data.datasets[5].data = data; // Update current data as well
        window.myChart.options.scales.y.title.text = datasetLabel;
        window.myChart.options.plugins.legend.position = legendPosition;
        window.myChart.options.plugins.title.text = `${datasetLabel} vs Month`;
        window.myChart.update();
    } else {
        createChart(canvas, chartType, labels, data, datasetLabel, legendPosition);
    }
};