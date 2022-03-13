function CustomConfirm(titulo, mensaje, tipo) {
    return new Promise((resolve) => {
        Swal.fire({
            title: titulo,
            text: mensaje,
            icon: tipo,
            
            background: 'linear-gradient(315deg, #ff7878 0%, #74d680 74%)',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Confirmar',
            cancelButtonText: 'Cancelar'
        }).then((result) => {
            if (result.value) {
                resolve(true);
            } else {
                resolve(false);
            }
        })
    });
}

function CustomSave(titulo, icono) {
    Swal.fire({
        position: 'center',
        icon: icono,
        background: 'linear-gradient(315deg, #ff7878 0%, #74d680 74%)',
        title: titulo,
        showConfirmButton: false,
        timer: 1500
    })
}